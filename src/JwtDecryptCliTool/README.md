# jwtdcli

Commandline tool (.NET 8, C#) die een geneste JWT (JWE met daarin een JWS) decrypt met een RSA private key, en toont de binnenliggende
header en payload (claims). 

## Bouwen

```bash
cd JwtDecryptCliTool
dotnet restore
dotnet build -c Release
```

## Gebruik

Verplichte argumenten.  
- --private-key *pad*     :PEM-bestand met de RSA private key (PKCS#1 of PKCS#8) gebruikt om de JWE te decrypten
- --token *jwe*           : De JWE compact-serialisatie (5 delen, gescheiden door '.')
- --token-file *pad*      : Alternatief voor --token: bestand met de JWE-string (als geen van beide is opgegeven wordt van stdin gelezen).  

Optionele argumenten.  
- --raw                   : Print alleen de gedecrypte JWS compact-string (geen extra opmaak)
- --out *pad*             : Schrijf de output naar dit bestand i.p.v. stdout
- --help                  : Toon deze help.  

Voorbeelden.  

```bash
dotnet run -- --private-key encryption_private.pem --token-file token.jwe
```

Of met de token direct als argument:

```bash
dotnet run -- --private-key encryption_private.pem --token "eyJhbGciOi...(hele JWE-string)"
```

Of via stdin

```bash
jwtdcli --private-key encryption_private.pem --token-file token.jwe
```

Alleen de gedecrypte JWS-compactstring teruggeven (bruikbaar voor verdere verwerking of om in
jwt.io te plakken):

```bash
dotnet run -- --private-key encryption_private.pem --token-file token.jwe --raw
```

Output naar file

```bash
dotnet run -- --private-key encryption_private.pem --token-file token.jwe --out token.jws --raw
```

Zie `jwtdcli --help` voor alle opties.

De resulterende JWS kan worden gevalideerd in jwt.io

## Voorbeeldoutput (zonder --raw)

```
=== Header (JWS) ===
{
  "alg": "RS256",
  "typ": "JWT"
}

=== Payload (claims) ===
{
  "patient": "123456789",
  "provider": "75751514",
  "jti": "...",
  "iss": "https://issuer.example",
  "aud": "https://audience.example",
  "iat": 1735000000,
  "nbf": 1735000000,
  "exp": 1735000900
}

=== Binnenliggende JWS (compact) ===
eyJhbGciOi...
```

## Ontwerpkeuzes

- **Zelf geïmplementeerde JWE-decryptie (RFC 7518), geen Microsoft.IdentityModel**: `JsonWebTokenHandler.ValidateTokenAsync` met `TokenDecryptionKey` maar zonder `ValidationKey` om de JWE
  automatisch te laten decrypten lijkt niet te werken — de decryptie werd
  overgeslagen. In plaats van verder te vertrouwen op dat library-gedrag is de decryptie nu zelf
  geïmplementeerd met alleen standaard .NET-cryptoprimitieven (`RSA`, `Aes`, `HMACSHA256/384/512`
  uit `System.Security.Cryptography`), rechtstreeks volgens RFC 7518:
  - key-unwrap van de content-encryption-key via RSA (§4.3: RSA-OAEP, RSA-OAEP-256, RSA1_5),
  - content-decryptie via AES-CBC met HMAC-integriteitscheck (§5.2: A128CBC-HS256,
    A192CBC-HS384, A256CBC-HS512), inclusief de MAC over AAD + IV + ciphertext + bit-lengte
    van de AAD, en constante-tijd tag-vergelijking.
- **PEM-parsing**: zelfde aanpak als `jwtcli` — `RSA.ImportFromPem` voor kale PEM-sleutels, met
  ondersteuning voor `-----BEGIN CERTIFICATE-----` als public-key-bestand een certificaat is.
- **Input**: token via `--token`, `--token-file`, of stdin (voor pipelines).

## Bekende beperkingen

- Alleen RSA-sleutels, net als bij `jwtcli`.
- Ondersteunde JWE-algoritmes: key-encryption RSA-OAEP / RSA-OAEP-256 / RSA1_5,
  content-encryption A128CBC-HS256 / A192CBC-HS384 / A256CBC-HS512 (dit dekt precies wat
  `jwtcli` produceert). AES-GCM content-encryptie wordt niet ondersteund, net zoals `jwtcli`
  dat niet produceert — zie de kanttekening in de README van `jwtcli`.
