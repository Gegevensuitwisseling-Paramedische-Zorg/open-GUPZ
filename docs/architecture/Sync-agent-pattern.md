#Sync agent pattern

# Synoniemen
FHIR-ETL

# Bedoeling
Een FHIR-sync-agent repliceert data uit een legacy systeem naar een FHIR compliant store, en (soms) vice versa. FHIR compliant clients kunnen zodoende data afkomstig uit het legacy systeem benaderen voor lezen en (soms) schrijven. 

Door toepassing van een FHIR-facade kunnen lagacy systemen FHIR compliant worden gemaakt. In het zogenaamde [FHIR besluit](https://open.overheid.nl/documenten/ronl-72d9d941c7ee7ae2c58c236290e152b22939448d/pdf) is door het ministerie van VWS besloten dat bij het beschikbaarstellen en uitwisselen van gezondheids(zorg)informatie gebruik dient te worden gemaakt van FHIR (versies STU3 of R4). Een FHIR-sync-agent voegt de daarvoor benodigde capabilities toe aan legacy systemen.

# Alternatieven
FHIR-facades zijn een alternatief voor FHIR-stores en het sync-agent pattern. Een FHIR-facade vertaalt FHIR requests in realtime naar verzoeken op het onderliggende legacy systeem, en de resultaten uit het legacy systeem naar FHIR compliant responses

# Probleem
FHIR is een relatief nieuwe standaard voor databeschikaarheid en gegevensuitwisseling in de (Nederlandse) zorg. Veel systemen van voor 2018 (de eerste normatieve release van FHIR was R4 in 2018) bieden daarom uit zichzelf geen FHIR API's. Een FHIR-store sync-agent voegt functionaliteit toe aan dit soort systemen waardoor zij native FHIR ondersteuning lijken te bieden.

FHIR ondersteuning is van belang om te kunnen voldoen aan het Nederlandse [FHIR besluit](https://open.overheid.nl/documenten/ronl-72d9d941c7ee7ae2c58c236290e152b22939448d/pdf) (en de sinds dat besluit ontwikkelde informatiestandaarden) en aan de [Europen Health Data Space](https://eur-lex.europa.eu/legal-content/EN/TXT/?uri=OJ:L_202500327) (EHDS).

# Oplossing
Een FHIR-facade bestaat uit de volgende onderdelen:

- Een Data Access Layer (DAL) specifiek voor het onderliggende legacy systeem
- Een FHIR library, met inplementaties voor alle FHIR datatypes en -resources (voor 1 of meerdere FHIR versies), FHIR encoders en FHIR parsers
- Specifieke API's, inclusief query opties, paging, operaties en andere API opties
- Een API Gateway die de toegang vanuit (publieke) netwerken reguleert en maatregelen toevoegt zoals authenticatie, encryptie, rate-limiting, load balancing en endpoint hiding  
  
![Sync-agent patroon](/assets/syncagent.jpg)

Voor PARIS leveranciers kan de inzet van een FHIR-facade de volgende inspanningen vragen:

- Het PARIS dient mogelijk te worden aangepast om semantische compatibiliteit met de benodigde FHIR resources te borgen. In Nederland kan die compatibiliteit worden geborgd door het interne datamodel ven het PARIS semantisch compatible te maken met zibs2017 (voor FHIR STU3) of zibs2020(FHIR R4)
- Een PARIS specifieke DAL dient te worden ontwikkeld, inclusief de bridge naar de (ontwikkelde of geselecteerde) FHIR-library., 

# Toepasbaarheid
Een FHIR-facade wordt gebruikt om FHIR API's toe te voegen aan legacy systemen in die gevallen waarin de vertaling van FHIR requests naar native queries/ API-calls, en weer terug van native response naar FHIR response, real-time plaats kan vinden. 

# Niet te gebruiken bij
Het FHIR-facade pattern dient niet te worden gebruikt in gevallen waarin het vertalen van FHIR Requests naar native queries/ API-calls, en weer terug van native response naar FHIR response, veel tijd in beslag neemt, bijvoorbeeld omdat:

- Extractie van data uit het native systeem veel tijd in beslag neemt
- Complexe en tijdrovende conversieregels nodig zijn voor conversie van native resultaten naar FHIR responses


# Voor en nadelen
Een FHIR-facade is vaak sterker gekoppeld aan het onderliggende legacy systeem dan een FHIR-store. Daardoor bevat een FHIR-facade minder herbruikbare componten dan een FHIR-store. Ook biedt de facade een directe attack factor op het onderliggende legacy systeem juist omdat de facade zo sterk is gekoppeld aan het legacy systeem.

Een belangrijk voordeel van een FHIR-facade is dat geen replicatie van data nodig is, zoals in het geval van een FHIR-store en het Sync-agent pattern. Daardoor is de kans op optreden van synchronisatiefouten (zoals verouderde data of zelfs inconsistenties) kleiner of niet-bestaand.

Voor data-intensieve requests kan een FHIR-facade veel stress veroorzaken op het onderliggende legacy systeem, en daardoor primaire processen verstoren.
