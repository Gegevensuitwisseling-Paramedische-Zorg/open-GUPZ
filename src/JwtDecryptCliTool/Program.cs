using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;

namespace JwtDecryptCliTool;

// Deze tool implementeert JWE-decryptie (RFC 7518) zonder afhankelijkheid van 
// Microsoft.IdentityModel.* — Micrisift.IdentiyModel.JsonWebTokenHandler.VaidateTonenAsync lijkt niet te werken 
// zonder verificatie van de signature
internal static class Program
{
    private static readonly string HelpText = string.Join(Environment.NewLine, new[]
    {
        "jwtdcli - decrypt een geneste JWT (JWE met daarin een JWS) met een RSA",
        "                private key, en toont de binnenliggende header/payload.",
        "",
        "Verplicht:",
        "  --private-key <pad>     PEM-bestand met de RSA private key (PKCS#1 of PKCS#8),",
        "                          gebruikt om de JWE te decrypten",
        "  --token <jwe>           de JWE compact-serialisatie (5 delen, gescheiden door '.')",
        "  --token-file <pad>      alternatief voor --token: bestand met de JWE-string",
        "                          (als geen van beide is opgegeven wordt van stdin gelezen)",
        "",
        "Optioneel:",
        "  --raw                   print alleen de gedecrypte JWS compact-string (geen extra opmaak)",
        "  --out <pad>             schrijf de output naar dit bestand i.p.v. stdout",
        "  --help                  toon deze help",
        "",
        "Ondersteunde JWE-algoritmes:",
        "  key-encryption (alg): RSA-OAEP, RSA-OAEP-256, RSA1_5",
        "  content-encryption (enc): A128CBC-HS256, A192CBC-HS384, A256CBC-HS512",
        "",
        "Voorbeeld:",
        "  jwtdcli --private-key encryption_private.pem --token-file token.jwe --raw",
        "",
    });

    private static int Main(string[] args)
    {
        try
        {
            if (args.Length == 0 || args.Contains("--help") || args.Contains("-h"))
            {
                Console.WriteLine(HelpText);
                return args.Length == 0 ? 1 : 0;
            }

            var options = ParseArgs(args);

            RequireOption(options, "private-key");
            string privateKeyPath = options["private-key"][0];

            string jwe = ReadToken(options);

            using RSA decryptionRsa = LoadRsaFromPem(privateKeyPath, isPrivate: true);

           
            try
            {               

                return Run(options, decryptionRsa, jwe);
            }
            catch (CliArgumentException ex)
            {
                Console.Error.WriteLine($"Fout: {ex.Message}");
                return 1;
            }
            
        }
        catch (CliArgumentException ex)
        {
            Console.Error.WriteLine($"Fout: {ex.Message}");
            Console.Error.WriteLine();
            Console.Error.WriteLine(HelpText);
            return 1;
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"Onverwachte fout: {ex.Message}");
            return 1;
        }
    }

    private static int Run(Dictionary<string, List<string>> options, RSA decryptionRsa, string jwe)
    {
        string innerJws = DecryptJwe(jwe, decryptionRsa);

        string[] jwsParts = innerJws.Split('.');
        if (jwsParts.Length != 3)
        {
            throw new CliArgumentException(
                $"De gedecrypte inhoud is geen geldige JWS compact-serialisatie (verwacht 3 delen, kreeg {jwsParts.Length}). " +
                "De JWE is mogelijk gedecrypt met de verkeerde private key.");
        }

        string headerJson = Encoding.UTF8.GetString(Base64UrlDecode(jwsParts[0]));
        string payloadJson = Encoding.UTF8.GetString(Base64UrlDecode(jwsParts[1]));

        bool rawOnly = options.ContainsKey("raw");
        string output;

        if (rawOnly)
        {
            output = innerJws;
        }
        else
        {
            output = string.Join(Environment.NewLine, new[]
            {
                "=== Header (JWS) ===",
                PrettyPrintJson(headerJson),
                "",
                "=== Payload (claims) ===",
                PrettyPrintJson(payloadJson),
                "",
                "=== Binnenliggende JWS (compact) ===",
                innerJws,
            });
        }

        if (options.TryGetValue("out", out var outValues))
        {
            File.WriteAllText(outValues[0], output);
            Console.WriteLine($"Output geschreven naar {outValues[0]}");
        }
        else
        {
            Console.WriteLine(output);
        }

        return 0;
    }

    // ----- JWE-decryptie (RFC 7518 §4/§5) -----

    private static string DecryptJwe(string jwe, RSA privateKey)
    {
        string[] parts = jwe.Split('.');
        if (parts.Length != 5)
        {
            throw new CliArgumentException(
                $"Token is geen geldige JWE compact-serialisatie (verwacht 5 door '.' gescheiden delen, kreeg {parts.Length}).");
        }

        string encodedHeader = parts[0];
        byte[] encryptedKey = Base64UrlDecode(parts[1]);
        byte[] iv = Base64UrlDecode(parts[2]);
        byte[] ciphertext = Base64UrlDecode(parts[3]);
        byte[] authTag = Base64UrlDecode(parts[4]);

        string headerJson = Encoding.UTF8.GetString(Base64UrlDecode(encodedHeader));

        using JsonDocument headerDoc = JsonDocument.Parse(headerJson);
        if (!headerDoc.RootElement.TryGetProperty("alg", out var algEl) ||
            !headerDoc.RootElement.TryGetProperty("enc", out var encEl))
        {
            throw new CliArgumentException("JWE-header mist het 'alg' en/of 'enc' veld.");
        }

        string alg = algEl.GetString() ?? throw new CliArgumentException("JWE-header 'alg' is leeg.");
        string enc = encEl.GetString() ?? throw new CliArgumentException("JWE-header 'enc' is leeg.");

        byte[] cek = UnwrapContentEncryptionKey(alg, encryptedKey, privateKey);
        byte[] aad = Encoding.ASCII.GetBytes(encodedHeader);
        byte[] plaintext = DecryptAesCbcHmac(enc, cek, iv, ciphertext, authTag, aad);

        return Encoding.UTF8.GetString(plaintext);
    }

    private static byte[] UnwrapContentEncryptionKey(string alg, byte[] encryptedKey, RSA rsa)
    {
        RSAEncryptionPadding padding = alg switch
        {
            "RSA-OAEP" => RSAEncryptionPadding.OaepSHA1,
            "RSA-OAEP-256" => RSAEncryptionPadding.OaepSHA256,
            "RSA1_5" => RSAEncryptionPadding.Pkcs1,
            _ => throw new CliArgumentException(
                $"Niet-ondersteund key-encryption-algoritme ('alg') in JWE-header: '{alg}'. " +
                "Ondersteund: RSA-OAEP, RSA-OAEP-256, RSA1_5."),
        };

        try
        {
            return rsa.Decrypt(encryptedKey, padding);
        }
        catch (CryptographicException ex)
        {
            throw new CliArgumentException(
                $"Kon de content-encryption-key niet unwrappen met de opgegeven private key " +
                $"(verkeerde/onbijpassende sleutel, of corrupt token?): {ex.Message}");
        }
    }

    private static byte[] DecryptAesCbcHmac(string enc, byte[] cek, byte[] iv, byte[] ciphertext, byte[] authTag, byte[] aad)
    {
        int keyBytes;
        Func<byte[], HMAC> hmacFactory;

        switch (enc)
        {
            case "A128CBC-HS256":
                keyBytes = 16;
                hmacFactory = k => new HMACSHA256(k);
                break;
            case "A192CBC-HS384":
                keyBytes = 24;
                hmacFactory = k => new HMACSHA384(k);
                break;
            case "A256CBC-HS512":
                keyBytes = 32;
                hmacFactory = k => new HMACSHA512(k);
                break;
            default:
                throw new CliArgumentException(
                    $"Niet-ondersteund content-encryption-algoritme ('enc') in JWE-header: '{enc}'. " +
                    "Ondersteund: A128CBC-HS256, A192CBC-HS384, A256CBC-HS512.");
        }

        int expectedCekLength = keyBytes * 2;
        if (cek.Length != expectedCekLength)
        {
            throw new CliArgumentException(
                $"Onverwachte lengte van de content-encryption-key na unwrap ({cek.Length} bytes, " +
                $"verwacht {expectedCekLength} bytes voor enc='{enc}'). Waarschijnlijk de verkeerde private key.");
        }

        byte[] macKey = cek[..keyBytes];
        byte[] encKey = cek[keyBytes..];

        // AL = 64-bit big-endian representatie van het aantal BITS in de AAD (RFC 7518 §5.2.2.1).
        long aadBits = (long)aad.Length * 8;
        byte[] al = new byte[8];
        for (int i = 0; i < 8; i++)
        {
            al[7 - i] = (byte)(aadBits >> (8 * i));
        }

        byte[] macInput = new byte[aad.Length + iv.Length + ciphertext.Length + al.Length];
        int offset = 0;
        Buffer.BlockCopy(aad, 0, macInput, offset, aad.Length);
        offset += aad.Length;
        Buffer.BlockCopy(iv, 0, macInput, offset, iv.Length);
        offset += iv.Length;
        Buffer.BlockCopy(ciphertext, 0, macInput, offset, ciphertext.Length);
        offset += ciphertext.Length;
        Buffer.BlockCopy(al, 0, macInput, offset, al.Length);

        using HMAC hmac = hmacFactory(macKey);
        byte[] fullTag = hmac.ComputeHash(macInput);
        byte[] computedTag = fullTag[..keyBytes];

        if (!CryptographicOperations.FixedTimeEquals(computedTag, authTag))
        {
            throw new CliArgumentException(
                "Integriteitscontrole (HMAC) van de JWE is mislukt. Waarschijnlijk de verkeerde " +
                "private key, of het token is corrupt/aangepast.");
        }

        using Aes aes = Aes.Create();
        aes.Key = encKey;
        aes.IV = iv;
        aes.Mode = CipherMode.CBC;
        aes.Padding = PaddingMode.PKCS7;

        using ICryptoTransform decryptor = aes.CreateDecryptor();
        try
        {
            return decryptor.TransformFinalBlock(ciphertext, 0, ciphertext.Length);
        }
        catch (CryptographicException ex)
        {
            throw new CliArgumentException($"AES-decryptie van de content mislukt: {ex.Message}");
        }
    }


    // ----- Hulpfuncties -----

    private static byte[] Base64UrlDecode(string input)
    {
        string s = input.Replace('-', '+').Replace('_', '/');
        s = (s.Length % 4) switch
        {
            2 => s + "==",
            3 => s + "=",
            0 => s,
            _ => throw new CliArgumentException("Ongeldige base64url-waarde in token."),
        };

        try
        {
            return Convert.FromBase64String(s);
        }
        catch (FormatException ex)
        {
            throw new CliArgumentException($"Ongeldige base64url-waarde in token: {ex.Message}");
        }
    }

    private static string PrettyPrintJson(string json)
    {
        using JsonDocument doc = JsonDocument.Parse(json);
        return JsonSerializer.Serialize(doc.RootElement, new JsonSerializerOptions { WriteIndented = true });
    }

    private static string ReadToken(Dictionary<string, List<string>> options)
    {
        if (options.TryGetValue("token", out var tokenValues))
        {
            return tokenValues[0].Trim();
        }

        if (options.TryGetValue("token-file", out var fileValues))
        {
            string path = fileValues[0];
            if (!File.Exists(path))
            {
                throw new CliArgumentException($"Token-bestand niet gevonden: {path}");
            }

            return File.ReadAllText(path).Trim();
        }

        string stdin = Console.In.ReadToEnd().Trim();
        if (string.IsNullOrEmpty(stdin))
        {
            throw new CliArgumentException("Geen token opgegeven. Gebruik --token, --token-file, of geef de JWE via stdin.");
        }

        return stdin;
    }

    private static RSA LoadRsaFromPem(string path, bool isPrivate)
    {
        if (!File.Exists(path))
        {
            throw new CliArgumentException($"{(isPrivate ? "Private" : "Public")} key bestand niet gevonden: {path}");
        }

        string pem = File.ReadAllText(path);

        if (!isPrivate && pem.Contains("BEGIN CERTIFICATE"))
        {
            using var cert = X509Certificate2.CreateFromPem(pem);
            RSA? certRsa = cert.GetRSAPublicKey();
            if (certRsa is null)
            {
                throw new CliArgumentException($"Certificaat in '{path}' bevat geen RSA public key.");
            }

            RSA rsa = RSA.Create();
            rsa.ImportRSAPublicKey(certRsa.ExportRSAPublicKey(), out _);
            return rsa;
        }

        RSA keyRsa = RSA.Create();
        try
        {
            keyRsa.ImportFromPem(pem);
        }
        catch (Exception ex)
        {
            string expected = isPrivate ? "PKCS#1 of PKCS#8 PEM" : "SubjectPublicKeyInfo PEM of certificaat";
            throw new CliArgumentException($"Kon key niet lezen uit '{path}' (verwacht {expected}): {ex.Message}");
        }

        return keyRsa;
    }

    private static Dictionary<string, List<string>> ParseArgs(string[] args)
    {
        var result = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);
        var flagOnlyOptions = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "raw", "help" };

        for (int i = 0; i < args.Length; i++)
        {
            string arg = args[i];
            if (!arg.StartsWith("--"))
            {
                throw new CliArgumentException($"Onverwacht argument: '{arg}'. Opties moeten beginnen met --.");
            }

            string name = arg[2..];

            bool hasValue = i + 1 < args.Length && !args[i + 1].StartsWith("--");
            if (!hasValue)
            {
                if (!flagOnlyOptions.Contains(name))
                {
                    throw new CliArgumentException($"Optie --{name} verwacht een waarde.");
                }

                AddOption(result, name, "true");
                continue;
            }

            string value = args[++i];
            AddOption(result, name, value);
        }

        return result;
    }

    private static void AddOption(Dictionary<string, List<string>> options, string name, string value)
    {
        if (!options.TryGetValue(name, out var list))
        {
            list = new List<string>();
            options[name] = list;
        }

        list.Add(value);
    }

    private static void RequireOption(Dictionary<string, List<string>> options, string name)
    {
        if (!options.ContainsKey(name) || options[name].Count == 0 || string.IsNullOrWhiteSpace(options[name][0]))
        {
            throw new CliArgumentException($"Verplichte optie --{name} ontbreekt.");
        }
    }
}

internal sealed class CliArgumentException : Exception
{
    public CliArgumentException(string message) : base(message)
    {
    }
}
