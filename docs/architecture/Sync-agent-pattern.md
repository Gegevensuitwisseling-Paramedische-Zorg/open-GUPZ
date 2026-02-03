#FHIR Sync agent pattern

# Synoniemen
FHIR-ETL

# Bedoeling
Een FHIR-sync-agent repliceert data uit een legacy systeem naar een FHIR compliant store, en (soms) vice versa. FHIR compliant clients kunnen zodoende data afkomstig uit het legacy systeem benaderen voor lezen en (soms) schrijven. 

Door toepassing van een FHIR-sync-agent kunnen lagacy systemen FHIR compliant worden gemaakt. In het zogenaamde [FHIR besluit](https://open.overheid.nl/documenten/ronl-72d9d941c7ee7ae2c58c236290e152b22939448d/pdf) is door het ministerie van VWS besloten dat bij het beschikbaarstellen en uitwisselen van gezondheids(zorg)informatie gebruik dient te worden gemaakt van FHIR (versies STU3 of R4). Een FHIR-sync-agent voegt de daarvoor benodigde capabilities toe aan legacy systemen.

# Alternatieven
FHIR-facades zijn een alternatief voor FHIR-stores en het sync-agent pattern. Een FHIR-facade vertaalt FHIR requests in realtime naar verzoeken op het onderliggende legacy systeem, en de resultaten uit het legacy systeem naar FHIR compliant responses

# Probleem
FHIR is een relatief nieuwe standaard voor databeschikaarheid en gegevensuitwisseling in de (Nederlandse) zorg. Veel systemen van voor 2018 (de eerste normatieve release van FHIR was R4 in 2018) bieden daarom uit zichzelf geen FHIR API's. Een FHIR-store sync-agent voegt functionaliteit toe aan dit soort systemen waardoor zij native FHIR ondersteuning lijken te bieden.

FHIR ondersteuning is van belang om te kunnen voldoen aan het Nederlandse [FHIR besluit](https://open.overheid.nl/documenten/ronl-72d9d941c7ee7ae2c58c236290e152b22939448d/pdf) (en de sinds dat besluit ontwikkelde informatiestandaarden) en aan de [Europen Health Data Space](https://eur-lex.europa.eu/legal-content/EN/TXT/?uri=OJ:L_202500327) (EHDS).

# Oplossing
Een FHIR-sync-agent bestaat uit de volgende onderdelen:

- Een sync-agent specifiek voor het onderliggende legacy systeem. De syncy agent reageert (near) realtime of op basis van regels op wijzigingen in het onderliggende PARIS of op wijzigingen in de FHIR-store en zet een replicatie-mechanisme in werking
- Een FHIR store, waarin uit het onderliggende PARIS gerepliceerde data wordt opgeslagen, of nieuwe data wordt opgeslagen die moet worden gerepliceerd naar het onderliggende PARIS
- PLUGINS die de aansluiting van de (PARIS specifieke) sync-agent op de (generieke) FHIR store verzorgen
- Specifieke API's en hun logica, inclusief query opties, paging, operaties en andere API opties
- Een API Gateway die de toegang vanuit (publieke) netwerken reguleert en maatregelen toevoegt zoals authenticatie, encryptie, rate-limiting, load balancing en endpoint hiding  
  
![Sync-agent patroon](/assets/syncagent.jpg)

Voor PARIS leveranciers kan de inzet van een FHIR-facade de volgende inspanningen vragen:

- Het PARIS dient mogelijk te worden aangepast om semantische compatibiliteit met de benodigde FHIR resources te borgen. In Nederland kan die compatibiliteit worden geborgd door het interne datamodel ven het PARIS semantisch compatible te maken met zibs2017 (voor FHIR STU3) of zibs2020(FHIR R4)
- Een PARIS specifieke sync-agent dient te worden ontwikkeld, inclusief de bridge(plugin) naar de (ontwikkelde of geselecteerde) FHIR-store.

# Toepasbaarheid
Een FHIR-sync-agent wordt gebruikt om FHIR API's toe te voegen aan legacy systemen in die gevallen waarin de vertaling van FHIR requests naar native queries/ API-calls, en weer terug van native response naar FHIR response, resource intensief en potentieel tijdrovend is.

# Niet te gebruiken bij
Het FHIR-sync-agent pattern dient niet te worden gebruikt in gevallen waarin FHIR requests en hun resulaten realtime kunnen worden vertaald naar native queries of API-calls. In dat geval dient het gebruik van een FHIR-facade te worden overwogen.


# Voor en nadelen
Een FHIR-sync-agent zorgt voor zwakke koppeling tussen het legacy systeem en de FHIR-store. Daardoor  bevat een FHIR-sync-agent meer herbruikbare componten dan een FHIR-facade. Ook scheidt de FHIR-sync-agent het attack-surface van de FHIR store van het onderliggende PARIS. Data-intensieve requests verzoorzaken geen directe stress op het onderliggende legacy systeem en kunnen worden 'geprepareerd'. Denk bijvoorbeeld aan het s' nachts prepareren en repliceren van FHIR documents of PDF/A documents. Daardoor is de kans dat data-intensieve requests productieprocessen verstoren kleiner dan bij gebruik van een FHIR-facade.

Een belangrijk nadeel van een FHIR-sync-agent is dat zij berust op replicatie van data. Daardoor is de kans op optreden van synchronisatiefouten (zoals verouderde data of zelfs inconsistenties) groter dan in het geval van een native FHIR applicatie of FHIR-facade.

