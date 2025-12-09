# Project Start Architectuur - Dataplatform voor de paramedische zorg
# Inleiding
Goede en tijdige informatie-uitwisseling met de patiënt en tussen zorgverleners onderling is nodig om kwalitatief goede en veilige zorg te kunnen leveren. Het programma ‘Gegevensuitwisseling in de Paramedische Zorg’ focust op de gestandaardiseerde uitwisseling van medische gegevens met de patiënt via een persoonlijke gezondheidsomgeving (PGO) en tussen zorgverleners onderling. Zo worden behandelingen effectief en worden fouten voorkomen. Gegevensuitwisseling vermindert bovendien overbodige administratieve lasten.

Voorliggende Project Start Architectuur (PSA) betreft de ontwikkeling van een FHIR gebaseerd dataplatform voor de paramedische zorg. Het platform ondersteunt gegevensuitwisseling en databeschkbaarheid in de paramedische zorg, en wordt ontwikkeld door samenwerkende leveranciers van Paramedische Informatie Systemen (PARIS). Leveranciers worden daarbij ondersteund door het programma Gegevensuitwisseling Paramedische Zorg (GUPZ). Alle specificaties, documentatie en eventuele broncode zullen worden beheerd in de 'open-GUPZ' Github repository. 

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
- Specificaties van documenttypes voor het beschikbaarstellen/ uitwisselen van ongestructureerde gegevens
- Standaard coderingen (SNOMED refsets)
- Specificaties van FHIR API's voor een dataplatform voor de paramedische zorg. 
>[!WARNING]
>How to connect to simplifier? OpenAPI?
- Aansluitspecificaties voor partijen die op een paramedisch dataplatform aan willen sluiten
- Solution architectuur van een dataplatform voor de paramedische zorg gebaseerd op twee alternatieve conceptuele architecturen
- Optioneel source code voor gezamenlijk ontwikkelde onderdelen van een dataplatform voor de paramedische zorg
  
# Uitgangspunten en principes

## Gelijk speelveld
## Open innovatie en samenwerking 
Onder andere deze repository met documentatie, specificaties en tools/ open source
## Gebruik van standaarden
Waaronder open aansluitspecificaties op PARIS
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
## Algemene Verordening Gegevensbeschreming (AVG)
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





