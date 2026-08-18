---
title: API Security
layout: template
filename: security.md
--- 

# Inleiding
> [!WARNING]
> Deze beschrijving is niet (volledig) van toepassing op de ZorgDomein API's

Een goede beveiliging van via het dataplatform beschikaar gestelde gegevens is een belangrijke vereiste. De te nemen beveiligingsmaatregelen volgen uit een risicoanalyse op basis van de STRIDE methodiek:

- Voorkomen dat een persoon, systeem of applicatie zich voordoet als iets of iemand anders en daardoor onterecht toegang verkrijgt tot het platform en de data die het platform beschikbaar stelt (Spoofing)
- Voorkomen dat data in rust of transit ongeautoriseerd wordt aangepast (Tampering)
- Borgen van onweerlegbaarheid van toegang tot het platform en de data die het platform beschikbaar stelt (non-Repudiation)
- Voorkomen dat informatie onterecht wordt bootgesteld (Information Disclosure)
- Voorkomen van Denial of service
- Afdwingen van autorisaties (voorkomen van Elevation of privilege)

# Risico analyse

> [!WARNING]
> Risico analyse is onvolledig en heeft verdere uitwerking nodig. Met name risico's van PARIS en internal flow

**Level 0 threat model**

![Level 0 threat model voor het data platform](/assets/open-GUPZ-threat-model-level0.jpg)

**FHIR API**

| # | Titel | Type | Beschrijving | Maatregelen |
| --| ---------- | ------------ | ----------- | -----|
|  | Aanvaller doet zich voor als FHIR API| Spoofing | Een aanvaller doet zich voor als de FHIR API van het dataplatform waardoor een vertrouwde externe partij vertrouwelijke gegevens naar de aanvaller stuurt en/ of onterecht vertrouwd op gegevens afkomstig van de aanvaller|mTLS op basis van PKI Overheid Private G4 server certificaat iom beveiligingsrichtlijnen voor TLS van NCSC, minimaal niveau Voldoende |
|  | Externe partij ontkent het opvragen of wijzigen van data bij het dataplatform| Non-Repudiation | Een extern systeem ontkent een actie op het dataplatform| Alle FHIR operaties (CRUD) worden gelogd conform NEN7513 |
| | Token replay | Elevation of Privilage | Aanvaller hergebruikt een token om toegang tot API's te verkrijgen | Maximaal geaccepteerde token lifespan van 15 minuten. Combinatie met mTLS. Overweeg het token te binden aan het client certificate |

**FHIR flow**

| # | Titel | Type | Beschrijving | Maatregelen |
| --| ---------- | ------------ | ----------- | -----|
|  | Blootstelling vertouwelijke gegevens in transit | Information Disclosure | Vertrouwelijke gegevens kunnen worden 'afgeluisterd' door een 'man in the middle' | Het dataplatform vereist TLS configuratie iom Beveiligingsrichtlijnen voor TLS van het NCSC, minimaal niveau Voldoende |
|  | Ongeautoriseerde aanpassing van gegevens in transit | Information Disclosure | Vertrouwelijke gegevens kunnen worden 'aangepast' door een 'man in the middle' | Het dataplatform vereist TLS configuratie iom Beveiligingsrichtlijnen voor TLS van het NCSC, minimaal niveau Voldoende |
|  | Blootstelling BSN | Information Disclosure | BSN uit het JWT token is leesbaar voor onvertrouwde tussenliggende componenten die TLS termination ? SSL offloading doen, zoals proxies en load balancers | Het dataplatform vereist een versleuteld JWT token. BSN's in FHIR urls worden niet ondersteund |

**External system**

| # | Titel | Type | Beschrijving | Maatregelen |
| --| ---------- | ------------ | ----------- | -----|
|  | Aanvaller doet zich voor als vertrouwd extern systeem | Spoofing | Een aanvaller doet zich voor als vertrouwd extern systeem, waardoor een dataplatform vertrouwelijke gegevens beschikbaar stelt aan de aanvaller | Het dataplatform vereist mutual TLS op basis van een PKI Overheid Private G4 certificaat iom beveiligingsrichtlijnen TLS van het NCSC, minimaal niveau Voldoende. Het dataplatform vereist een door het vertrouwde externe systeem digitaal ondertekend JWT |


# Uitwerking van maatregelen 
Beveiligingsmaatregelen kunnen worden onderverdeeld in de volgende categorieën:

- Transport level security
- Application level security
- Audit trail
  
## Transport level security
Het dataplatform vereist mutual TLS (mTLS). Hierdoor wordt geborgd dat:
- Alle verkeer tussen het dataplatform en het externe systeem wordt versleuteld
- Het externe systeem kan het dataplatform authenticeren op basis van het server certificaat dat het dataplatform presenteert tijdens de TLS handshake
- Het dataplatfom kan het vertrouwde externe systeem authenticeren op basis van het client certificaat dat het externe systeem presenteert tijdens de TLS handshake


### Eisen aan de TLS configuratie
De TLS configuratie dient te voldoen aan de [beveiligingsrichtlijnen voor Transport Level Security](https://www.ncsc.nl/transport-layer-security-tls/v21-tls) van het Nationaal Cyber Security Centrum (NCSC), minimaal op veiligheidsniveau 'Voldoende'. Voor de TLS configuratie betekent dit dat gebruik van TLS 1.2 (Voldoende) of TLS 1.3(Goed) wordt vereist.

Voor TLS 1.2 worden de volgende cypher suites ondersteund:
- ECDHE-ECDSA-AES256-GCM-SHA384
- ECDHE-ECDSA-AES128-GCM-SHA256
- ECDHE-RSA-AES256-GCM-SHA384
- ECDHE-RSA-AES128-GCM-SHA256
- ECDHE-ECDSA-CHACHA20-POLY1305
- ECDHE-RSA-CHACHA20-POLY1305

Voor TLS 13 worden de volgende cypher suites ondersteund:
- TLS_AES_256_GCM_SHA384
- TLS_CHACHA20_POLY1305_SHA256
- TLS_AES_128_GCM_SHA256

### Eisen aan de te gebruiken certificaten
Het dataplatform presenteert een PKI Overheid Private G4 certificaat aan het externe systeem. Een multitenant dataplatform (een dataplatform dat door meerdere paramedische praktijken wordt gebruikt) kan hetzelfde PKI overheid certificaat gebruiken voor alle onderliggende praktijken.

Het dataplatform vereist dat het externe systeem een PKI Overheid Private G4 certificaat presenteert tijdens de TLS handshake

Voor testdoeleinden is het gebruik van een G4 certificaat niet vereist.

## Application level security
Aan iedere HTTP call naar een FHIR API van het dataplatform wordt een ondertekend en versleuteld JWT token (NESTED JWT) toegevoegd aan de HTTP Authorization header. Een JWT token dat wordt gebruikt in een patiëntgebonden request is patientspecifiek. Dit betekent dat voor iedere patiënt waarvoor data bij het dataplatform wordt opgehaald, een nieuw token moet worden gemaakt.

### JWS token inhoud

**JWS Token header**
De token header bevat de volgende velden:

| veld | betekenis | waarde | Verplicht |
|---|---|---|---|
| alg | Signing algorithm| Vaste waarde: RS256| Ja |
| typ | Type token | Vaste waarde: JWT | Ja |
| kid | ID van de Key gebruikt voor signing | alfanumerieke identifier van de key in de JWKS keyset | Ja |

**JWS Token payload**
De token payload bevat de volgende claims:

| veld | betekenis | waarde | Voorbeeld| Verplicht |
|---|---|---|---|---|
| patient | BSN van de patiënt waarvan gegevens worden opgevraagd of gewijzigd | http://fhir.nl/fhir/NamingSystem/bsn\|{bsn} | http://fhir.nl/fhir/NamingSystem/bsn\|000000012 | Voor patiëntgebonden requests|
| provider | Zorgaanbieder waarvoor het verzoek bestemd is | http://fhir.nl/fhir/NamingSystem/agb-z\|{agb} | http://fhir.nl/fhir/NamingSystem/agb-z\|20000001| Nee |
| sub | Gebruiker die het request initieert. Dit is ofwel de patiënt (zelde waarde als patient claim), ofwel een gemachtigde ofwel een zorgverlener| http://fhir.nl/fhir/NamingSystem/bsn\|{bsn} of een string igv een zorgverlener | http://fhir.nl/fhir/NamingSystem/bsn\|000000012 | Ja |
| iat | Moment waarop het token gecreeerd is. Wordt door dataplatform gebruikt om maximale token lifetime te kunnen controleren | Numeric Date | 1617181723 | Ja |
| exp | Uiterlijke moment van geldigheid van het token | Numeric Date| 1617182623| Ja |
| iss | Token issuer | String | ZorgDomein | Ja |
| nbf | Note before, eerste moment vanaf wanneer het token geldig is | Numeric Date | 1617181723 | Nee |
| jti | Unieke ID token | String | 4a006a12-dc2b-470a-b031-a3682b653ba7 | Nee |
| aud | Resource server waarvoor de JWT geldig is (de specifieke dataplatform instantie) | String | https://praktijkx.dataplatform.nl | Ja |
| scope | Diensten (resources) waarvoor het JWT geldig is | String. Eén of meerdere scopes, gescheiden door een spatie | medmij.gegevensdienst.51 medmij.gegevensdienst.47 | ja |
| cnf. x5t#S256 | De base64url-gecodeerde SHA-256-hash van de DER-gecodeerde clientcertificaat-bytes, iom RFC 8705 | String | bwcK0esc3ACC3DB2Y5_lESsXE8o9ltc05O89jdN-dg2 | Nee |

### Token beveiliging
Het gebruikte JWT token bevat gevoelige informatie, waaronder met name het BSN van de patiënt waarvoor informatie wordt benaderd. Het token dient daarom te worden beveiligd om te voorkomen dat:

- De inhoud van het token wordt aangepast door een onbevoegde/ kwaadwillende partij (token integriteit)
- De inhoud van het token wordt blootgesteld aan een onbevoegde/ kwaadwillende partij (token vertrouwelijkheid)
- Een onvertouwde partij een token kan genereren dat afkomstig lijkt van een vertrouwde partij (token authenticiteit)

Het dataplatform gaat uit van de volgende stappen voor JWT token beveiliging:

- Key exchange: Het vertrouwde externe systeem gebruikt een private signing key om het JWT te ondertekenen en de public encryption key van het dataplatform om het JWT te versleutelen. Het dataplatform gebruikt de public signing key van het externe systeem om de digital signature te verifieren en haar private encryption key om de JWT te ontsluetelen
- Sign the JWT (JWS): Het vertrouwde externe systeem creeert het JWT en ondertekend het met de private signing key
- Encrypt the JWT (JWE): Het vertrouwde externe systeem versleutelt het resulterende ondertekende JWT met behulp van de public encryption key van het dataplatform
- Het vertrouwde externe systeem verstuurt het versleutelde token in de HTTP Authorization header: Authorization bearer <encrypted token>. Het dataplatform ontsleutelt het token met behukp van zijn private encryption key en valideert de digital signature met behulp van de public signing key van het vertrouwde externe systeem
- Het dataplatform valideert de creation time van het JWT token. Indien deze langer is dan 15 minuten (900 seconden) geleden dan wordt het request geweigerd (geldige tokens voldoen aan: now-iat < 900)
- Het dataplatform valideert de expiration time van het JWT token. Indien deze is verstreken wordt het request geweigerd (geldige tokens voldoen aan: now<exp)
- Het dataplatform valideert de issuer van het token 

Het token wordt eerst gesigned, waarna de resulterende JWS als inhoud wordt opgenomen in een JWE.Dit staat bekend als 'NESTED JWT', omdat het ondertekende token wordt opgenomen als waarde in het encrypted token. De resulterende JWE heeft de volgende header velden:

| veld | betekenis | waarde | Verplicht |
|---|---|---|---|
| alg | Asymmetrisch algoritme gebruikt om de sleutel te versleutelen | Vaste waarde: RSA-OAEP | Ja |
| enc | Symmetrisch algoritme om de inhoud te versleutelen | Vaste waaarde: A256CBC-HS512 | Ja |
| cty | Content Type | Vaste waarde: JWT | Ja |

> [!IMPORTANT]
> Ondersteuning van RFC 8705 is optioneel voor zowel het dataplatform als clients op het dataplatform. Verwacht wordt dat RFC 8705 op termijn verplicht zal worden gesteld. Dit betekent dat clients aan het token een cnf. x5t#S256 claim toevoegen met de base64url-gecodeerde SHA-256-hash van de DER-gecodeerde clientcertificaat-bytes. Het dataplatform zal dan controleren of het token ook daadwerkelijk is gebonden aan het betreffende clientcertificaat.


### MedMij specifieke eisen op het gebied van application level security ###
In tokens afkomstig van een MedMij DVA wordt het JWT scope field door de DVA gevuld met één of meer van de geldige MedMij gegevensdienstnummers conform het volgende format:
> medmij.gegevensdienst.**nummer van de gegevensdienst**

Het dataplatform mag in dit geval controleren:
- Of de issuer (iss) inderdaad een DVA is
- Of de DVA deze gegevensdienst op mag vragen bij het dataplatform   
  Dit kan bijvoorbeeld afhangen van of de gegevensdienst gekwalificeerd is (zie [de MedMij deelnemerlijst](https://medmij.nl/overzicht-kandidaat-deelnemers/))

### Eisen aan de te gebruiken certificaten
Voor zowel de signing keys als de encryption keys worden X.509 certificaten gebruikt uitgegegen door een trusted Certificate Authority (CA).

**Signing Key**
- Key usage: digitalSignature
- Signing algorithm: RSA-SHA256

**Encryption Key**
- Key usage: keyEncipherment 
- Key Encryption Algoritm: RSA-OAEP
- Content Encryption Algorithm: A256CBC-HS512


### Key rotation
Het dataplatform gebruikt JWKS key rotation om verlopen keys tijdig en automatisch te vervangen door nieuwe keys.

**Rotatie van de signing key**
De client van het dataplatform biedt een JWKS document aan op /.well-known/jwks.json en publiceert daarin de keys die worden gebruikt om de tokens te ondertekenen. Het dataplatform haalt automatisch de jwks opnieuw op wanneer het token een onbekende 'kid' bevat. 

***Rotatie van de encryptie key***
Het dataplatform biedt een JWKS document aan op /.well-known/jwks.json en publiceert daarin de keys die worden gebruikt om de tokens te versleutelen.


### Afhandeling van ongeldige tokens
Wanneer tokenvalidatie mislukt retourneert het dataplatform een HTTP 401 response met een WWW-Authenticate header.

```
HTTP/1.1 401 Unauthorized
WWW-Authenticate: Bearer realm="[url dataplatform-server]",
  error="invalid_token",
  error_description="The access token expired"
```

De body van het response bevat een OperationOutcome resource:

```
{
  "resourceType": "OperationOutcome",
  "issue": [{
    "severity": "error",
    "code": "login",
    "diagnostics": "The access token has expired"
  }]
}
```

> [!WARNING]
> De inhoud van WWW-Authenticate. error_description en OperationOutcome.issue.diagnostics moet gelijk zijn.

> [!WARNING]
> De error_description en issue.diagnostics mogen geen details bevatten van de validatiefout, anders dan dat het token is verlopen of dat signature_validation is gefaald.

> [!IMPORTANT]
> Voor testdoeleinden is het toegestaan meer details op te nemen in de error_description en issue.diagnostics. Tijdens het testen dient echter ook aangetoond te kunnen worden dat het opnemen van dit soort details kan worden uitgeschakeld


### Afhandeling van ontbrekende autorisatie
Indien een request wordt gedaan dat buiten de in het token opgenomen scope valt retourneert het dataplatform een HTTP 403 response met een WWW_Authenticate header:

```
HTTP/1.1 403 Forbidden
WWW-Authenticate: Bearer realm="[url dataplatform-server]",
  error="insufficient_scope",
  error_description="Insufficient scope: '[vereiste scope]' is required for this operation",
  scope="[de benodigde scope, zoals het MedMij gegevensdienst nummer, zodat de client deze alsnog kan aanvragen/ sturen]"
```

De body van het response bevat een OperationOutcome resource:

```
{
  "resourceType": "OperationOutcome",
  "issue": [{
    "severity": "error",
    "code": "forbidden",
    "diagnostics": "Insufficient scope: '[vereiste scope]' is required for this operation"
  }]
}
```

> [!WARNING]
> De inhoud van WWW-Authenticate. error_description en OperationOutcome.issue.diagnostics moet gelijk zijn.


## Audit trail
Het dataplatform implementeert audit trail die voldoet aan NEN7513. Als gebruiker MOET de waarde van de sub claim worden gelogd
