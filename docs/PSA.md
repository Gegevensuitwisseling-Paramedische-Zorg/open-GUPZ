# Project Start Architectuur - Dataplatform voor de paramedische zorg
# Inleiding
Goede en tijdige informatie-uitwisseling met de patiënt en tussen zorgverleners onderling is nodig om kwalitatief goede en veilige zorg te kunnen leveren. Het programma ‘Gegevensuitwisseling in de Paramedische Zorg’ focust op de gestandaardiseerde uitwisseling van medische gegevens met de patiënt via een persoonlijke gezondheidsomgeving (PGO) en tussen zorgverleners onderling. Zo worden behandelingen effectief en worden fouten voorkomen. Gegevensuitwisseling vermindert bovendien overbodige administratieve lasten.

Voorliggende Project Start Architectuur (PSA) betreft de ontwikkeling van (specificaties voor) een FHIR gebaseerd dataplatform voor de paramedische zorg. Het platform ondersteunt gegevensuitwisseling en databeschikbaarheid in de paramedische zorg, en wordt ontwikkeld door samenwerkende leveranciers van Paramedische Informatie Systemen (PARIS). Leveranciers worden daarbij ondersteund door het programma Gegevensuitwisseling Paramedische Zorg (GUPZ). Alle specificaties, documentatie en eventuele broncode zullen worden beheerd in de 'open-GUPZ' Github repository. 

## Doelstelling programma GUPZ
In het programma Gegevensuitwisseling Paramedische Zorg wordt gewerkt aan verschillende doelen:

- Het realiseren van gegevensuitwisseling tussen paramedici en huisartsen, medisch specialisten en paramedici onderling.  Wanneer zorgverleners medische gegevens uitwisselen, kan zorg nog beter op elkaar worden afgestemd en vermindert dit administratieve lasten.
- Het realiseren van gegevensuitwisseling tussen paramedici en de patiënt. Gegevens worden uitgewisseld met de patiënt via de persoonlijke gezondheidsomgeving (PGO). De patiënt krijgt op deze manier meer inzicht in zijn of haar paramedische gegevens via een PGO.

Meer informatie over het programma is te vinden op ![Gegevensuitwisseling Paramedische Zorg](https://gegevensuitwisselingparamedischezorg.nl/)

Het programma kent een ambitieuze tijdlijn. De bij het programma betrokken leveranciers willen daarom optimaal samenwerken bij de ontwikkeling van de benodigde specificaties en software.

![Tijdlijn van het GUPZ programma](/assets/timeline.jpg)

## Ambities open-GUPZ 
Binnen het programmaonderdeel 'open-GUPZ' werken de betrokken PARIS leveranciers en de GUPZ organisatie samen aan de ontwikkeling van (open specificaties en tools voor) een FHIR gebaseerd dataplatform voor de paramedische zorg. Door gezamenlijke ontwikkeling van specificaties en waar mogelijk ook software, wordt versnelling bereikt bij de realisatie van de doelen van het programma GUPZ. Gezamenlijk ontwikkelde specificaties en software worden beheerd in de 'open-GUPZ' Github repository.

Open-GUPZ heeft ambities op drie gebieden:

### Waarde voor eindgebruikers die opweegt tegen de investeringen:
- Verlagen van de administratieve lasten voor behandelaars waardoor meer tijd overblijft voor de patient
- Duidelijkheid zorg(plan) voor patient door verminderen van informatie ruis
- Patienten op veilige (informatiebeveiliging en veiligheid) manier informeren
- Professionele uitstraling door juiste en veilige dataoverdracht
- Overzichtelijke investeringen en kostenoptimalisatie voor de paramedische praktijk.
  
### Versnellen door open innovatie:
- Samenwerken bij research & development van specificaties, documentatie en code 
- Compliant zijn aan wet en regelgeving op de meest efficiente manier
- Verschillen en overeenkomsten met eerdere MedMij & vergelijkbare trajecten duidelijk krijgen en lessons leurned inbrengen
- Fundament voor toekomstige ontwikkelingen, maar geen alle dingen doekjes
- Vroegtijdig betrokken zodat geen grote inhaalslag nodig is wanneer wetgeving zaken verplicht stelt PE 18-11
- Leren van andere sectoren
- Bij voorkeur één uniforme manier van compliant zijn aan huidige en toekomstige wet- en rtegelgeving
- beperking benodigde kennisgebieden (programmeertalen/applicaties/...)

### Gelijk speelveld
- Open aansluitspecificaties voor Dienstverlener zorgaanbieder (DVA), Verwijsplatform, Netwerk Informatie Systemen en andere zorginformatiesystemen
- Keuzevrijheid voor paramedische praktijken bij de keuze van een DVA, verwijsplatform en andere zorginformatiesystemen

## Eindproducten 
Het programmaonderdeel 'open-GUPZ' levert ten minste de volgende eindproducten:
- Een Project Start Architectuur (PSA) voor een FHIR gebaseerd dataplatform voor de paramedische zorg
- Een uitwerking van verschillende oplossingsrichtingen in de vorm van software architecture patterns of 'implementatieprofielen'
- Een lijst met 'pas toe of leg uit' standaarden 
- Specificaties van FHIR API's voor een dataplatform voor de paramedische zorg. 
>[!WARNING]
>How to connect to simplifier? OpenAPI?
- Eisen aan aansluitvoorwaarden voor partijen die op een paramedisch dataplatform aan willen sluiten
- Optioneel source code voor gezamenlijk ontwikkelde onderdelen van een dataplatform voor de paramedische zorg
- Specificaties van documenttypes voor het beschikbaarstellen/ uitwisselen van ongestructureerde gegevens
- Standaard coderingen (SNOMED refsets)
- Minimale functionele requirements/ capablities op het gebied van verwijzen en het beschikbaar stellen van informatie aan patiënten
  
# Uitgangspunten en principes

## Gelijk speelveld
open-GUPZ wil een bijdrage leveren aan een goed functionerende markt voor zorg-ict in de paramedische sector. Dit betekent dat open-GUPZ wil voorkomen dat paramedische praktijken zich gedwongen zien om diensten en systemen als 'totaaloplossing' af te nemen van één leverancier, of enkele leveranciers in een vast samenwerkingsverband, en dat overstapkosten van diensten of systemen beperkt, transparent en voorspelbaar blijven. In de praktijk betekent dit vooral:
- Vrije keuze van een PARIS. Vervanging van het PARIS moet mogelijk zijn zonder dat ook de Dienstverlener Zorgaanbieder (DVA), het Verwijsplatform, het Netwerk Informatie Systeem en/ of andere op het PARIS aangesloten toepassingen voor primair of secundair gebruik moeten worden worden vervangen. Vervanging van het PARIS heeft een voorspelbare (fininanciele) impact.
- Vrije keuze van de Dienstverlener Zorgaanbieder (DVA). Vervanging van de DVA moet mogelijk zijn zonder vervanging van het PARIS en met een voorspelbare (financiële) impact
- Vrije keuze van Netwerk Informatiesysteem (NIS). Vervanging van het NIS moet mogelijk zijn zonder vervanging van het PARIS en met een voorspelbare (financiële) impact
- Vrije keuze van een Verwijsplatform. Vervanging van het Verwijsplatform moet mogelijk zijn zonder vervanging van het PARIS en met een voorspelbare (financiële) impact
- Vrije keuze van andere op het PARIS aangesloten toepassingen voor primair of secundair gebruik  moet mogelijk zijn zonder vervanging van het PARIS en met een voorspelbare (financiële) impact.

Het uitgangspunt 'gelijk speelveld' wordt bereikt doordat de bij open-GUPZ aangesloten leveranciers zich conformeren aan:
- Het gebruik van open standaarden
- Waar mogelijk en van toepassing het gebruik van best-practices en implementatieprofielen zoals gespecificeerd binnen open-GUPZ
- Waar mogelijk en van toepassing implementeren van Generieke functies en aansluiten bij de Gemeenschappelijke Voorzieningen zoals deze worden ontwikkeld in het kader van het Landelijk Dekkend Netwerk
- Het hanteren van transparante API-aansluitvoorwaarden die voldoen aan de Nictiz 'API requirements for Dutch Healthcare', en dan met name de categorie 'API agreements'

## Gebruik van open standaarden
open-GUPZ maakt gebruik van een lijst van 'pas toe of leg uit' -standaarden voor de ontwikkeling van specificaties en implementatieprofielen. Het gebruik van open standaarden bevordert de interoperabiliteit en daarmee de communicatie en samenwerking tussen verschillende zorginformatiesystemen en -applicaties. Het gebruik van opsn standaarden is daarmee een belangrijke voorwaarde voor het creeren van een gelijk speelveld. 'Pas toe of leg uit' -standaarden zullen worden gebruikt op alle niveau's van het Nictiz interoperabiliteitsmodel.

## Gebruik van openbare best-practices en implementatieprofielen

## Open innovatie en samenwerking 
Onder andere deze repository met documentatie, specificaties en tools/ open source

## Implementatievrijheid 
## Waarde voor eindgebruikers
## Hergebruik
## Seperation of concerns
Ook de gelaagde API structuur benoemen
![Three layer API architecture](/assets/3_layer_api_architecture.jpg)
## Reductie van complexiteit
## Seperation of concerns
FHIR complexiteit scheiden van PARIS
## Make, join or buy

# Grondslagen
## Algemene Verordening Gegevensbescherming (AVG)
## Wet aanvullende bepalingen verwerking persoonsgegevens in de zorg (Wabvpz)
## Wet op geneeskundige behandelovereenkomst (WGBO)
## European Health Data Space (EHDS)
## Network and Information Security Directive (NIS2)

# Organisatie/ stakeholders
Geef hier een eerste indicatie van de (rol van) stakeholders die betrokken zijn bij (de oplossing voor) het vraagstuk. 

# Informatie
Geef hier een eerste indicatie van de informatie-objecten die relevant zijn bij (de oplossing voor) het vraagstuk.

# Standaarden
## FHIR 
STU3 en R4 discussie
## MedMij PDF/A
## Informatiestandaard paramedie
## Terminologie (SNOMED CT)


# Architectuur patronen
## Sync-agent
![Sync-agent patroon](/assets/syncagent.jpg)

## FHIR Facade
![FHIR-facade patroon](/assets/facade.jpg)

# Privacy en Informatiebeveiliging

# Beheer





