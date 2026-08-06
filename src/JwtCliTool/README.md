# jwtcli

Commandline tool (.NET 8, C#) dat een JWT genereert op basis van commandline-parameters,
de JWT signeert (JWS, RS256) met een RSA private key uit een PEM-bestand, en het resultaat
vervolgens encrypt als een geneste JWE (RSA-OAEP + A256CBC-HS512) met een RSA public key uit een
ander PEM-bestand. Het eindresultaat is dus: **JWS in JWE** (industriestandaard "nested JWT").

## Bouwen

```bash
cd JwtCliTool
dotnet restore
dotnet build -c Release
```


## Testsleutels genereren (voorbeeld met OpenSSL)

Signing-sleutelpaar (voor het JWS-deel):

```bash
openssl genrsa -out signing_private.pem 2048
openssl rsa -in signing_private.pem -pubout -out signing_public.pem
```

Encryptie-sleutelpaar (voor het JWE-deel — let op: de tool signt met de **private** key van het
eerste paar en encrypt met de **public** key van het tweede paar; dit mogen ook dezelfde sleutels
zijn als je maar één RSA-paar wilt gebruiken):

```bash
openssl genrsa -out encryption_private.pem 2048
openssl rsa -in encryption_private.pem -pubout -out encryption_public.pem
```

## Gebruik

```bash
dotnet run -- \
  --signing-key private_signing_key.pem 
  --encryption-key public_encryption_key.pem 
  --iat 1786025213 
  --exp 1786028873  
  --patient 123456789 \
  --provider 06010520 \
  --iss https://issuer.example \
  --aud https://audience.example \
  --scope "patient/read" \
  --out token.txt
```


Zie `jwtcli --help` voor alle opties.

## Verifiëren / decrypten (voor testdoeleinden)

Met de private key van het encryptie-paar kun je de JWE decrypten en de binnenliggende JWS
controleren, bijvoorbeeld met een kleine dotnet-fx snippet of met een tool als `jose` /
`step` CLI, of met jwt.io (plak eerst de gedecrypte JWS daar in — jwt.io ondersteunt geen JWE).

## Ontwerpkeuzes

- **Nested JWT (JWS → JWE)**: `Microsoft.IdentityModel.JsonWebTokens.JsonWebTokenHandler.CreateToken`
  bouwt automatisch een geneste token wanneer zowel `SigningCredentials` als
  `EncryptingCredentials` op de `SecurityTokenDescriptor` staan: eerst wordt de JWT ondertekend
  (JWS/RS256), daarna wordt die JWS als payload ge-encrypt tot een JWE (RSA-OAEP key-wrap +
  AES-256-GCM content-encryptie). Dit is de gangbare, interoperabele manier om "signed en
  encrypted" JWT's te bouwen.
- **PEM-parsing**: gebruikt `RSA.ImportFromPem` (PKCS#1 of PKCS#8) en, voor public keys,
  ondersteunt het ook een `-----BEGIN CERTIFICATE-----` PEM (X.509) naast een kale
  SubjectPublicKeyInfo PEM.
- **Claims**: `patient`, `provider`, `jti` (default: nieuwe GUID) en optioneel `scope` gaan als
  custom claims mee; `iss`, `aud`, `iat`, `nbf`, `exp` gebruiken de daarvoor bedoelde
  `SecurityTokenDescriptor`-properties zodat de handler ze correct wegschrijft.


## Bekende beperkingen

- Alleen RSA-sleutels worden ondersteund 

