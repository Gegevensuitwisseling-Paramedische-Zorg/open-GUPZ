using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;

namespace JwtCliTool;

internal static class Program
{
    private static readonly string HelpText = string.Join(Environment.NewLine, new[]
    {
        "jwtcli - genereert een JWT, signeert met een RSA private key (JWS/RS256)",
        "         en encrypt het resultaat als geneste JWE (RSA-OAEP + A256CBC-HS512).",
        "",
        "Verplicht:",
        "  --signing-key <pad>     PEM-bestand met de RSA private key (PKCS#1 of PKCS#8), voor signing",
        "  --encryption-key <pad>      PEM-bestand met de RSA public key (SubjectPublicKeyInfo of certificaat), voor encryptie",
        "  --iat <unix-seconds>    issued-at (iat). Standaard: nu",
        "  --exp <unix-seconds>    expiry (exp). Heeft voorrang op --ttl",     
        "  --iss <waarde>          issuer (iss)",   
        "",
        "Optioneel:",
        "  --patient <waarde>      Waarde voor de \"patient\" claim",
        "  --provider <waarde>     Waarde voor de \"provider\" claim",
        "  --aud <waarde>          audience (aud)",
        "  --scope <waarde>        scope claim",
        "  --jti <waarde>          JWT ID (jti). Standaard: nieuwe GUID",
        "  --nbf <unix-seconds>    not-before (nbf). Standaard: nu",
        "  --help                  toon deze help",
        "  --out <pad>             schrijf JWT naar bestand in plaats van stdout",
        "",
        "Voorbeeld:",
        "  jwtcli --signing-key private_signing_key.pem --encryption-key public_encryption_key.pem  \\",
        "         --iat 1786025213 --exp 1786028873 --iss https://issuer.example \\",
        "         --patient 123456789 --provider 06010520 \\",
        "         --aud https://audience.example --scope \"patient/read\" ---out token.txt ",
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

            RequireOption(options, "signing-key");
            RequireOption(options, "encryption-key");
            RequireOption(options, "iat");
            RequireOption(options, "exp");
            RequireOption(options, "iss");

            string privateKeyPath = options["signing-key"][0];
            string publicKeyPath = options["encryption-key"][0];

            using RSA signingRsa = LoadPrivateKey(privateKeyPath);
            using RSA encryptionRsa = LoadPublicKey(publicKeyPath);

            string jwe = BuildToken(options, signingRsa, encryptionRsa);

            if (options.TryGetValue("out", out var outValues))
            {
                File.WriteAllText(outValues[0], jwe);
                Console.WriteLine($"JWT geschreven naar {outValues[0]}");
            }
            else
            {
                Console.WriteLine(jwe);
            }

            return 0;
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

    private static string BuildToken(Dictionary<string, List<string>> options, RSA signingRsa, RSA encryptionRsa)
    {
        DateTime now = DateTime.UtcNow;

        long iat = GetLongOption(options, "iat") ?? ToUnixSeconds(now);
        long nbf = GetLongOption(options, "nbf") ?? iat;
        long exp = GetLongOption(options, "exp") ?? (iat + 600);

        string sigAlg = GetSingleOption(options, "sig-alg") ?? SecurityAlgorithms.RsaSha256;
        string encAlgKw = GetSingleOption(options, "enc-alg") ?? SecurityAlgorithms.RsaOAEP;
        string encAlgContent = GetSingleOption(options, "enc") ?? SecurityAlgorithms.Aes256CbcHmacSha512;

        var claims = new Dictionary<string, object>
        {
            ["patient"] = GetSingleOption(options, "patient")!,
            ["provider"] = GetSingleOption(options, "provider")!,
            ["jti"] = GetSingleOption(options, "jti") ?? Guid.NewGuid().ToString(),
        };

        string? scope = GetSingleOption(options, "scope");
        if (scope is not null)
        {
            claims["scope"] = scope;
        }

        string? iss = GetSingleOption(options, "iss");
        string? aud = GetSingleOption(options, "aud");


        var descriptor = new SecurityTokenDescriptor
        {
            Issuer = iss,
            Audience = aud,
            IssuedAt = DateTimeOffset.FromUnixTimeSeconds(iat).UtcDateTime,
            NotBefore = DateTimeOffset.FromUnixTimeSeconds(nbf).UtcDateTime,
            Expires = DateTimeOffset.FromUnixTimeSeconds(exp).UtcDateTime,
            Claims = claims,
            SigningCredentials = new SigningCredentials(new RsaSecurityKey(signingRsa), sigAlg),
            EncryptingCredentials = new EncryptingCredentials(new RsaSecurityKey(encryptionRsa), encAlgKw, encAlgContent),
        };

        var handler = new JsonWebTokenHandler();
        return handler.CreateToken(descriptor);
    }

    private static RSA LoadPrivateKey(string path)
    {
        if (!File.Exists(path))
        {
            throw new CliArgumentException($"Private key bestand niet gevonden: {path}");
        }

        string pem = File.ReadAllText(path);
        RSA rsa = RSA.Create();
        try
        {
            rsa.ImportFromPem(pem);
        }
        catch (Exception ex)
        {
            throw new CliArgumentException($"Kon private key niet lezen uit '{path}' (verwacht PKCS#1 of PKCS#8 PEM): {ex.Message}");
        }

        return rsa;
    }

    private static RSA LoadPublicKey(string path)
    {
        if (!File.Exists(path))
        {
            throw new CliArgumentException($"Public key bestand niet gevonden: {path}");
        }

        string pem = File.ReadAllText(path);

        if (pem.Contains("BEGIN CERTIFICATE"))
        {
            using var cert = X509Certificate2.CreateFromPem(pem);
            RSA? certRsa = cert.GetRSAPublicKey();
            if (certRsa is null)
            {
                throw new CliArgumentException($"Certificaat in '{path}' bevat geen RSA public key.");
            }

            // GetRSAPublicKey() kan een handle teruggeven die leeft zolang het certificaat leeft;
            // exporteer daarom expliciet naar een losstaand RSA object.
            RSA rsa = RSA.Create();
            rsa.ImportRSAPublicKey(certRsa.ExportRSAPublicKey(), out _);
            return rsa;
        }

        RSA pubRsa = RSA.Create();
        try
        {
            pubRsa.ImportFromPem(pem);
        }
        catch (Exception ex)
        {
            throw new CliArgumentException($"Kon public key niet lezen uit '{path}' (verwacht SubjectPublicKeyInfo PEM of certificaat): {ex.Message}");
        }

        return pubRsa;
    }

    private static Dictionary<string, List<string>> ParseArgs(string[] args)
    {
        var result = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);

        for (int i = 0; i < args.Length; i++)
        {
            string arg = args[i];
            if (!arg.StartsWith("--"))
            {
                throw new CliArgumentException($"Onverwacht argument: '{arg}'. Opties moeten beginnen met --.");
            }

            string name = arg[2..];
            if (i + 1 >= args.Length || args[i + 1].StartsWith("--"))
            {
                throw new CliArgumentException($"Optie --{name} verwacht een waarde.");
            }

            string value = args[++i];
            if (!result.TryGetValue(name, out var list))
            {
                list = new List<string>();
                result[name] = list;
            }

            list.Add(value);
        }

        return result;
    }

    private static void RequireOption(Dictionary<string, List<string>> options, string name)
    {
        if (!options.ContainsKey(name) || options[name].Count == 0 || string.IsNullOrWhiteSpace(options[name][0]))
        {
            throw new CliArgumentException($"Verplichte optie --{name} ontbreekt.");
        }
    }

    private static string? GetSingleOption(Dictionary<string, List<string>> options, string name) =>
        options.TryGetValue(name, out var values) ? values[0] : null;

    private static long? GetLongOption(Dictionary<string, List<string>> options, string name)
    {
        string? raw = GetSingleOption(options, name);
        if (raw is null)
        {
            return null;
        }

        if (!long.TryParse(raw, out long value))
        {
            throw new CliArgumentException($"Optie --{name} moet een geheel getal zijn (unix-seconden), kreeg: '{raw}'.");
        }

        return value;
    }

    private static long ToUnixSeconds(DateTime dt) => new DateTimeOffset(dt).ToUnixTimeSeconds();
}

internal sealed class CliArgumentException : Exception
{
    public CliArgumentException(string message) : base(message)
    {
    }
}
