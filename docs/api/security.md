# Inleiding
Een goede beveiliging van via het dataplatform beschikaar gestelde gegevens is een belangrijke vereiste. De te nemen beveiligingsmaatregelen volgen uit een risicoanalyse op basis van de STRIDE methodiek:

- Voorkomen dat een persoon, systeem of applicatie zich voordoet als iets of iemand anders en daardoor onterecht toegang verkrijgt tot het platform en de data die het platform beschikbaar stelt (Spoofing)
- Voorkomen dat data in rust of transit ongeautoriseerd wordt aangepast (Tampering)
- Borgen van onweerlegbaarheid van toegang tot het platform en de data die het platform beschikbaar stelt (non-Repudiation)
- Voorkomen dat informatie onterecht wordt bootgesteld (Information Disclosure)
- Voorkomen van Denial of service
- Afdwingen van autorisaties (voorkomen van Elevation of privilege)

# Risico analyse FHIR Facade pattern

![Threat model voor het FHIR Facade pattern](/assets/FHIR-Facade-threat-model.jpg)

**FHIR Facade**

| # | Titel | Type | Beschrijving | Maatregelen |
| --| ---------- | ------------ | ----------- | -----|
|  | Aanvaller doet zich voor als dataplatform| Spoofing | Een aanvaller doet zich voor als een dataplatform waardoor een vertrouwde externe partij vertrouwelijke gegevens naar de aanvaller stuurt en/ of onterecht vertrouwd op gegevens afkomstig van de aanvaller|TLS op basis van PKI Overheid Private G1 server certificaat iom beveiligingsrichtlijnen voor TLS van NCSC, minimaal niveau Voldoende |
|  | Externe partij ontkent het opvragen of wijzigen van data bij het dataplatform| Non-Repudiation | Een extern systeem ontkent een actie op het dataplatform| Alle FHIR operaties (CRUD) worden gelogd conform NEN7513 |

**FHIR flow**

| # | Titel | Type | Beschrijving | Maatregelen |
| --| ---------- | ------------ | ----------- | -----|
|  | Blootstelling vertouwelijke gegevens in transit | Information Disclosure | Vertrouwelijke gegevens kunnen worden 'afgeluisterd' door een 'man in the middle' | Het dataplatform vereist TLS configuratie iom Beveiligingsrichtlijnen voor TLS van het NCSC, minimaal niveau Voldoende |
|  | Ongeautoriseerde aanpassing van gegevens in transit | Information Disclosure | Vertrouwelijke gegevens kunnen worden 'aangepast' door een 'man in the middle' | Het dataplatform vereist TLS configuratie iom Beveiligingsrichtlijnen voor TLS van het NCSC, minimaal niveau Voldoende |
|  | Blootstelling BSN | Information Disclosure | BSN uit het JWT token is leesbaar voor onvertrouwde tussenliggende componenten die TLS termination ? SSL offloading doen, zoals proxies en load balancers | Het dataplatform vereist een versleuteld JWT token |

**External system**

| # | Titel | Type | Beschrijving | Maatregelen |
| --| ---------- | ------------ | ----------- | -----|
|  | Aanvaller doet zich voor als vertrouwd extern systeem | Spoofing | Een aanvaller doet zich voor als vertrouwd extern systeem, waardoor een dataplatform vertrouwelijke gegevens beschikbaar stelt aan de aanvaller | Het dataplatform vereist mutual TLS op basis van een PKI Overheid Private G1 certificaat iom beveiligingsrichtlijnen TLS van het NCSC, minimaal niveau Voldoende. Het dataplatform vereist een door het vertrouwde externe systeem digitaal ondertekend JWT |


# Risico analyse Sync-agent pattern

# Uitwerking van maatregelen 

## Transport level security
Het dataplatform vereist mutual TLS (mTLS). Hierdoor wordt geborgd dat:
- Alle verkeer tussen het dataplatform en het externe systeem wordt versleuteld
- Het externe systeem kan het dataplatform authenticeren op basis van het server certificaat dat het dataplatform presenteert tijdens de TLS handshake
- Het dataplatfom kan het externe systeem authenticeren op basis van het client certificaat dat het externe systeem presenteert tijdens de TLS handshake


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
Het dataplatform presenteert een PKI Overheid Private G1 certificaat aan het externe systeem. 
Het dataplatform vereist dat het externe systeem een PKI Overheid Private G1 certificaat presenteert tijdens de TLS handshake

## Application level security

### Token inhoud

**Token header**

**Token payload**

### Token ondertekening

### Token versleuteling

### Eisen aan de te gebruiken certificaten

### Vernieuwen van certificaten

## Logging
Het dataplatform imnplementeert audit trail die voldoet aan NEN7513.
