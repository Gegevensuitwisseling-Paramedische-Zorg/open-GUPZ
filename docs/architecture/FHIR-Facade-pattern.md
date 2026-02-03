# FHIR-facade pattern

# Synoniemen
Virtual FHIR Server, Legacy-to-FHIR Interface, FHIR Adapter, FHIR Bridge, API Translation Layer/Wrapper, Data Mapping Layer, Virtual Repository

# Bedoeling
Een FHIR-facade biedt FHIR compliant API's op een lagacy systeem dat zelf geen (FHIR) gestandaardiseerde toegang tot gezondheids(zorg)informatie biedt. Een FHIR-facade acteert als een real-time vertaler: Restfull FHIR requests worden realtime vertaald naar legacy queries of API-calls, en de resultaten van die queries en calls terug naar FHIR responses.

Door toepassing van een FHIR-facade kunnen lagacy systemen FHIR compliant worden gemaakt. In het zogenaamde [FHIR besluit](https://open.overheid.nl/documenten/ronl-72d9d941c7ee7ae2c58c236290e152b22939448d/pdf) is door het ministerie van VWS besloten dat bij het beschikbaarstellen en uitwisselen van gezondheids(zorg)informatie gebruik dient te worden gemaakt van FHIR (versies STU3 of R4). Een FHIR-facade voegt de daarvoor benodigde capabilities toe aan legacy systemen.

# Alternatieven
FHIR stores zijn een alternatief voor FHIR-facades. In dat geval synchroniseert een sync-agent data in legacy systemen (near realtime of batchgewij, afhankelijk van de vereisten) naar een FHIR-compliant data store, en vice versa.

# Probleem
FHIR is een relatief nieuwe standaard voor databeschikaarheid en gegevensuitwisseling in de (Nederlandse) zorg. Veel systemen van voor 2018 (de eerste normatieve release van FHIR was R4 in 2018) bieden daarom uit zichzelf geen FHIR API's. Een FHIR-facade voegt functionaliteit toe aan dit soort systemen waardoor zij native FHIR ondersteuning lijken te bieden.

FHIR ondersteuning is van belang om te kunnen voldoen aan het Nederlandse [FHIR besluit](https://open.overheid.nl/documenten/ronl-72d9d941c7ee7ae2c58c236290e152b22939448d/pdf) (en de sinds dat besluit ontwikkelde informatiestandaarden) en aan de [Europen Health Data Space](https://eur-lex.europa.eu/legal-content/EN/TXT/?uri=OJ:L_202500327) (EHDS).

# Oplossing
TBD
![FHIR-facade patroon](/assets/facade.jpg)

# Toepasbaarheid
Een FHIR-facade wordt gebruikt om FHIR API's toe te voegen aan legacy systemen in die gevallen waarin de vertaling van FHIR requests naar native queries/ API-calls, en weer terug van native response naar FHIR response, real-time plaats kan vinden. 

# Niet te gebruiken bij
Het FHIR-facade pattern dient niet te worden gebruikt in gevallen waarin het vertalen van FHIR Requests naar native queries/ API-calls, en weer terug van native response naar FHIR response, veel tijd in beslag neemt, bijvoorbeeld omdat:

- Extractie van data uit het native systeem veel tijd in beslag neemt
- Complexe en tijdrovende conversieregels nodig zijn voor conversie van native resultaten naar FHIR responses


# Voor en nadelen



