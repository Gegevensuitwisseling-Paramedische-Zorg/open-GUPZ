---
title: Project Start Architectuur - Dataplatform voor de paramedische zorg
layout: template
filename: PSA.md
--- 
# Project Start Architectuur - Dataplatform voor de paramedische zorg
## Inleiding
Goede en tijdige informatie-uitwisseling met de patiënt en tussen zorgverleners onderling is nodig om kwalitatief goede en veilige zorg te kunnen leveren. Het programma ‘Gegevensuitwisseling in de paramedische zorg’ (GUPZ) focust op de gestandaardiseerde uitwisseling van medische gegevens met de patiënt via een persoonlijke gezondheidsomgeving (PGO) en tussen zorgverleners onderling. Zo worden behandelingen effectief en worden fouten voorkomen. Gegevensuitwisseling vermindert bovendien overbodige administratieve lasten.

Voorliggende Project Start Architectuur (PSA) betreft de ontwikkeling van (specificaties voor) een FHIR gebaseerd dataplatform voor de paramedische zorg. Het platform ondersteunt gegevensuitwisseling en databeschikbaarheid in de paramedische zorg, en wordt ontwikkeld door samenwerkende leveranciers van Paramedische Informatie Systemen (PARIS). Leveranciers worden daarbij ondersteund door het programma Gegevensuitwisseling paramedische zorg (GUPZ). Alle specificaties, documentatie en eventuele broncode zullen worden beheerd in de 'open-GUPZ' Github repository. 

## Doelstelling programma GUPZ
In het programma Gegevensuitwisseling paramedische zorg wordt gewerkt aan verschillende doelen:

- Het realiseren van gegevensuitwisseling tussen paramedici en huisartsen, medisch specialisten en paramedici onderling.  Wanneer zorgverleners medische gegevens uitwisselen, kan zorg nog beter op elkaar worden afgestemd en vermindert dit administratieve lasten. De focus van GUPZ ligt op de realisatie van digitaal verwijzen.

- Het realiseren van gegevensuitwisseling tussen paramedici en de patiënt. Gegevens worden uitgewisseld met de patiënt via de persoonlijke gezondheidsomgeving (PGO). De patiënt krijgt op deze manier meer inzicht in zijn of haar paramedische gegevens via een PGO. De focus van GUPZ ligt op het beschikbaarstellen van behandelplan, documenten en verslagen als PDF/A document aan het PGO.

Meer informatie over het programma is te vinden op [Gegevensuitwisseling paramedische zorg](https://gegevensuitwisselingparamedischezorg.nl/)

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
- Samenwerken om compliance aan wet en regelgeving te bereiken
- Leren van  eerdere projecten en lessons learned inbrengen
- Creeren van een stevig Fundament voor toekomstige ontwikkelingen, maar met een duidelijke scope (databeschikbaarheid)
- Vroegtijdig betrokken zijnzodat geen grote inhaalslag nodig is wanneer wetgeving zaken verplicht stelt PE 18-11
- Leren van andere sectoren
- beperking benodigde kennisgebieden (programmeertalen/applicaties/...)

### Gelijk speelveld
- Open aansluitspecificaties voor Dienstverlener zorgaanbieder (DVA), Verwijsplatform, Netwerk Informatie Systemen en andere zorginformatiesystemen
- Keuzevrijheid voor paramedische praktijken bij de keuze van een DVA, verwijsplatform en andere zorginformatiesystemen

## Eindproducten 
Het programmaonderdeel 'open-GUPZ' levert ten minste de volgende eindproducten:
- Een [Project Start Architectuur (PSA)](/docs/PSA.md) voor een FHIR gebaseerd dataplatform voor de paramedische zorg
- Een uitwerking van verschillende oplossingsrichtingen in de vorm van [software architecture patterns](/docs/architecture) en 'implementatieprofielen'
- Een lijst met [pas toe of leg uit standaarden](/docs/standards/Pas-toe-leg-uit-standaarden.md)
- Open API specificaties van FHIR API's voor een dataplatform voor de paramedische zorg. 
- Eisen aan [aansluitvoorwaarden](/docs/policies/aansluitvoorwaarden.md) voor partijen die op een paramedisch dataplatform aan willen sluiten
- Specificaties van [documenttypes](/docs/terminology/documenttypes.md) voor het beschikbaarstellen/ uitwisselen van ongestructureerde gegevens
- [Standaard coderingen](/docs/terminology) (SNOMED refsets)
- [Minimale functionele requirements/ capablities](/docs/requirements) op het gebied van verwijzen en het beschikbaar stellen van informatie aan patiënten
- Beleidsondersteunende tools voor paramedische praktijken, zoals een [standaard privacyverklaring](/docs/policies/Privacyverklaring.md), [aansluitvoorwaarden](/docs/policies/Aansluitvoorwaarden.md) en [Risicomitigatie](/docs/policies/DPIA.md)
- Optioneel source code voor gezamenlijk ontwikkelde onderdelen van een dataplatform voor de paramedische zorg

# Organisatie/ stakeholders
Geef hier een eerste indicatie van de (rol van) stakeholders die betrokken zijn bij (de oplossing voor) het vraagstuk. 
## Projectorganisatie
>[!WARNING]
>Saskia T...zullen we deze samen oppakken?

## Samenwerkingsafspraken
De open-GUPZ Github repository bevat de specificaties, documentatie, architecture patterns, implementatieprofielen en overige artefacten die zijn ontwikkeld door de deenemende PARIS leveranciers. Regels voor het gebruik van github zijn opgenomen in ![README.md](/README.md).

Virtuele en fysieke bijeenkomsten worden periodiek verzorgd vanuit het programma GUPZ.

## Stakeholdermanagement
>[!WARNING]
>Saskia T...zullen we deze samen oppakken?

# Uitgangspunten en principes
open-GUPZ hanteert de volgende uitgangspunten en principes:

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
open-GUPZ ontwikkelt een lijst van [pas toe of leg uit -standaarden](/docs/standards/Pas-toe-leg-uit-standaarden.md) voor de ontwikkeling van een dataplatform voor de paramedische zorg. Het gebruik van open standaarden bevordert de interoperabiliteit en daarmee de communicatie en samenwerking tussen verschillende zorginformatiesystemen en -applicaties. Het gebruik van open standaarden is daarmee een belangrijke voorwaarde voor het creeren van een gelijk speelveld. 'Pas toe of leg uit' -standaarden zullen worden gebruikt op alle niveau's van het Nictiz interoperabiliteitsmodel.

## Gebruik van openbare architecture patterns en implementatieprofielen
open-GUPZ ontwikkelt software architecture patterns en implementatieprofielen als blauwdruk voor de implementatie van een dataplatform voor de paramedische zorg. Gebruik van architecture patterns en implementatieprofielen voorkomt of beperkt leverancier-specifieke implementatie van de verplichte standaarden en het ontstaan van monolitische 'totaaloplossingen'. Het gebruik van architecture patterns en implementatieprofielen is daarmee een belangrijke voorwaarde voor het creeren van een gelijk speelveld. 

## Open innovatie en samenwerking 
PARIS leverenciers willen samenwerken, onderling en met andere stakeholders, en gezamenlijk de ideeen, technologieen en kennis ontwikkelen die nodig is voor de realisatie van een state of the art dataplatform voor de paramedische zorg. Alles dat wordt ontwikkeld wordt publiek gedeeld in De open-GUPZ repository en website.

## Seperation of concerns
De scope van het dataplatform voor de paramedische zorg is duidelijk afgebakend: Het leveren van fijnmazige, use-case agnostische, FHIR gebaseerde system API's op het Paramedisch Informatiesysteem (PARIS). 'Seperation of concerns' wil zeggen dat het dataplatform ontkoppeld is van use-case/ afsprakenstelsel specifieke API's (process API's) en API clients (apps), zoals:
- Een Dienstverlener Zorgaanbieder (DVA) in het kader van MedMij gebaseerde uitwisseling met het PGO
- Een Verwijsplatform
- Een Netwerk Informatie Systeem (NIS)

Afbakening voorkomt het ontstaan van monolitische 'totaaloplossingen' en leverancierspecifieke implementaties van standaarden. Daarnaast reduceert afbakening de complexiteit van het platform, omdat afsprakenstelsel-specifieke maatregelen (zoals die binnen het MedMij afsprakenstelsel) niet door het platform zelf hoeven te worden geïmplementeerd.

![Three layer API architecture](/assets/3_layer_api_architecture.jpg)

## Hergebruik
open-GUPZ streeft naar maximaal hergebruik van alles wat door de deelnemende PARIS leveranciers wordt ontwikkeld. Specificaties worden zo generiek en herbruikbaar mogelijk ontworpen. Principes als 'seperation of concerns', 'gebruik van open standaarden' en 'gebruik van openbare software archirecture patterns en implementatieprofielen' zijn hiervoor een belangrijke voorwaarde.

Het dataplatform voor de paramedische zorg functioneert als een gestandaardiseerd toegangspunt tot ieder aangesloten PARIS. Dit leidt een herbruikbaar koppelvlak voor bijvoorbeeld aanbieders van de MedMij DVA rol, aanbieders van verwijsplatforms en aanbieders ven Netwerk Informatie Systemen (NIS)

## Reductie van complexiteit
PARIS leveranciers willen de complexiteit van de door hen ontwikkelde systemen beperken. Door 'seperation of concerns' kan het gebruik technologiën en implementatieprofielen die specifiek zijn voor een bepaald afsprakenstelsel zoals MedMij, binnen het dataplatform worden voorkomen of beperkt. Door scheiding van het dataplatform van het PARIS zelf, wordt voorkomen dat de complexiteit van het PARIS toeneemt.
 Door open innovatie en samenwerking kunnen complexe componten van het dataplatform gezamenlijk worden gespecificeerd en/ of ontwikkeld. 

## Just enough architecture
open-GUPZ ontwikkelt software archtecture patterns met als doel om verschillen bij de implementatie van standaarden te voorkomen of beperken. Het detailniveau van de ontwikkelde architectuur is precies voldoende voor dat doen, en niet meer dan dat. Teveel detail zal de implementatievrijheid van PARIS leveranciers en andere stakeholders onnodig beperken.

## Implementatievrijheid 
PARIS leveranciers streven naar implementatievrijheid. Dat wil zeggen dat open-GUPZ zoveel mogelijk ontwikkekplatform en -taal agnostische specificaties en patterns zal bevatten. Eventuele opensource implentaties kunnen dienen als referentie-implementatie. 

## Make, join or buy
Bij de ontwikkeling van een dataplatform voor de paramedische zorg worden alleen componenten ontwikkeld die niet opensource of commercieel, tegen een redelijk tarief, beschikbaar zijn. Make, join or buy beslissingen worden gezamenlijk gemaakt en gedocumenteerd.

## Privacy by design
open-GUPZ hanteert de 'privacy by design ontwerpfilosofie', die vereist dat privacybescherming vanaf het begin af aan meegenomen wordt bij het ontwerpen en bouwen van nieuwe systemen. Concreet betekent dit dat op de 'privacy ontwerp strategieën' uit [Het blauwe boekje](https://www.cs.ru.nl/~jhh/blauwe-boekje.html) zullen worden toegepast op het ontwerp van het dataplatform voor de paramedische zorg.

## Security in depth
open-GUPZ hanteert de [ICT-beveiligingsrichtlijnen voor webapplicaties](https://www.ncsc.nl/ict-beveiligingsrichtlijnen-webapplicaties) van het Nationaal Cyber Security Center bij het opstellen van:
- Software arcitecture patterns (richtlijnen voor de laag 'webapplicaties')
- Implementatieprofielen voor de inrichting van platformen, webservers en netwerken (richtlijnen voor de lagen 'Platform en webservers' en 'Netwerken')

## Waarde voor eindgebruikers
De bovenstaande uitgangspunten en principes zijn ondergeschikt aan de waarde voor eindgebruikers. Mitz beargumenteerd (pas toe of leg uit) kan worden afgeweken van de bovenstaande uitgangspunten en principes indien dit aantoonbaar bijdraagt aan de waarde voor eindgebruikers.

# Juridische context

## Grondslag voor de verwerking van gegevens
Een dataplatform voor de paramedische zorg is een middel bij de verwerking van (bijzondere) persoonsgegevens en valt daarom onder de invloedssfeer van de Algemene Verordening Gegevensbescherming (AVG). Dit betekent in ieder geval dat de aanbieder van het dataplatform verwerker is en verwerking alleen is toegestaan voor zover deze is overeengekomen in een verwerkersovereenkomst met de verwerkingsverantwoordelijke, zijnde de paramedische praktijk. De grondslag voor verwerking van deze gegevens is dat zij nodig zijn voor het uitvoeren van de behandeling. Zorginstellingen zijn uitgezonderd van het verbod op het verwerken van gegevens over gezondheid, enkel voor zover de verwerking noodzakelijk is met het oog op een goede behandeling of verzorging van de betrokkene dan wel het beheer van de betreffende instelling of beroepspraktijk (artikel 30 lid 3 UAVG).  

Een dataplatform voor de paramedische zorg verwerkt gegevens afkomstig uit het onderliggende PARIS van één paramedische praktijk. Dit betekent dat alle door het dataplatfom verwerkte gegevens net zo noodzakelijk zijn met het oog op goede behandeling als de gegevens in het PARIS. Doel(beschikbaar stellen) en middelen (dataplatform) veranderen wel en dienen te worden verwoord in de verwerkersovereenkomst.

Een dataplatform voor de paramedische zorg kan worden gezien als Elektronisch Uitwisselingssysteem zoals bedoeld in de Wet aanvullende Bepalingen Verwerking Persoonsgegevens in de Zorg (WABVPZ). Dit betekent dat de vanuit de WABVPZ gestelde eisen aan zo'n uitwisselingssysteem in principe ook gelden voor het dataplatform voor de paramedische zorg. Dit betreft vooral eisen op het gebied van de [rechten van de betrokkene](#rechten-van-de-betrokkene) en op het gebied van [gegevensdeling](#grondslag-voor-het-delen-van-gegevens).

## Rechten van de betrokkene
De AVG stelt eisen ten aanzien van de rechten van de betrokkene (de patiënt). Het dataplatform voor de paramedische zorg ondersteunt bij de implementatie van sommige van deze eisen:
- De eis op dataportabiliteit. Het dataplatform stelt data beschikbaar in een standaard (FHIR) formaat. Daarmee is data portable
- Recht op inzage. Het dataplatform stelt data beschikbaar aan de patiënt zelf en ondersteunt daarmee diens recht op inzage.

Op grond van de Wet Aanvullende Bepalingen Verwerking Persoonsgegevens in de Zorg (WABVPZ) heeft de patiënt daarnaast recht op een eletronisch afschrift van gegevens. Omdat het dataplatform voor de paramedische zorg gegevens elektronisch/ digitaal beschikbaar stelt, ondersteunt zij bij de implementatie van dit recht.

Voor het recht op gegevenswissing en rectificatie en aanvulling (AVG), geldt dat het dataplatform voor de paramedische zorg het onderliggende PARIS als bron van gegevens gebruikt. Gegevens die worden gerectificeerd, aangevuld of gewist in het onderliggende PARIS, zullen automatisch moeten worden gerectificeerd, aangevuld of gewist. De architectuur van het dataplatform dient dit te waarborgen.

Het recht op inzage van logging (WABVPZ) vereist dat patiënten kosteloos een (elektronisch) afschrift op kunnen vragen, waarin staat wie wanneer informatie heeft verstrekt, ingezien of opgevraagd in het elektronisch uitwisselingssysteem. De architectuur van het dataplatform dient te borgen dat een dergelijk elektronisch afschrift eenvoudig kan worden aangeleverd.

Op grond van de AVG heeft de betrokkene recht op informatie over doel en middelen van de verwerking. Deze informatie dient door de verwerkingsverantwoordelijke (de paramedische praktijk) te worden verstrekt. Vanuit open-GUPZ zal een standaard [privacyverklaring](/docs/policies/privacyverklaring.md) worden ontwikkeld die kan worden opgenomen in de website van de paramedische praktijk.

## Niet functionele eisen op het gebied van privacy en security
De AVG stelt ontwerpeisen in het kader van privacy (privacy by design, privacy by default) en security (passende maatregelen). Binnen open-GUPZ worden deze eisen gedekt vanuit de principes [privacy by design](#privacy-by-design) en [security in depth](#security-in-depth).

De Verordening betreffende elektronische identificatie en vertrouwensdiensten (eIDAS) stelt eisen aan de betrouwbaarheid van authenticatie door personen (zorgverleners, patiënten). open-GUPZ gaat uit van [seperation of concerns](#Seperation-of-concerns). De authenticatie van personen is geen 'concern' van het dataplatform maar een 'concern' van de brokers die de use case specifieke process API's aanbieden.

De AVG verplicht de verwerkingsverantwoordelijke om een data protection impact assessment (DPIA) uit te voeren als een gegevensverwerking waarschijnlijk een hoog privacyrisico oplevert voor de mensen van wie de organisatie gegevens verwerkt. De verwerking van gegevens over gezondheid door een dataplatform kan worden gezien als een risicovolle verwerking waarvoor een DPIA verplicht is. open-GUPZ ontwikkelt een  [factsheet met risico's en mitigerende maatregelen](/docs/policies/DPIA.md)ten behoeve van het uitvoeren van een DPIA.

Naleving van NEN7510, NEN7513 en NEN712 is verplicht en verankerd in onder andere de WABVPZ, het besluit elektronische gegevensverwerking voor zorgaanbieders (Begz) en Regeling Gebruik Burgerservicenummer. Certificering van NEN7510 is niet verplicht, maar de Inspectie Gezondheidszorg en Jeugd (IGJ) ziet toe op naleving en verwacht dat zorgaanbieders aantoonbaar werken volgens de NEN7510 om de continuïteit en veiligheid van zorg te waarborgen. Naleving van NEN7510 is verplicht voor alle zorgaanbieders en staat los van het eventuele gebruik van een dataplatform voor de paramedische zorg. Vanuit de WABPVPZ is naleving van NEN7512 en NEN7513 verplicht. Voor deze normen bestaat geen certificering. Consequenties voor (de architectuur van) het dataplatform voor de paramedische Zorg zijn onder andere:

- Audittrail dient aantoonbaar te voldoen aan de NEN7513. De architectuur van het dataplatform dient dit te borgen.
- Of voldaan dient te worden aan NEN7512 is afhankelijk van de use case (niet voor MedMij bijvoorbeeld). NEN7512 compliance is daarom niet in scope van het dataplatform voor de paramedische zorg, maar wel in scope voor de brokers die de use case specifieke process API's aanbieden.
- [Beheer](#beheer) van het dataplatform dient te worden ingericht in overeenstemming met NEN7510

De  Network and Information Security Directive 2 (NIS2), in Nederland geïmplemeteerd door de Cyberbeveiligingswet(CBW) vereist implementatie van strenge beveiligingsnormen voor organisaties groter dan 50 personen of met een jaarlijkse omzet van meer dan 10 miljoen. NIS2 is van toepassing op groeiend aantal PARIS leveranciers. Er bestaat geen specifieke NIS2 certificering, maar ISO27001 en NEN7510 certificering sluiten nauw aan bij de eisen uit NIS2. Voor het dataplatform voor de paramedische zorg worden de volgende maatregelen voorzien:

- [Beheer](#beheer) van het dataplatform dient te worden ingericht in overeenstemming met NEN7510
- [Security in depth](#security-in-depth) wordt ingericht in overeenstemming met de beveiligingsrichtlijnen voor webapplicaties van het Nationaal Cyber Security Center)
  
## Niet functionele eisen op het gebied van databeschikbaarheid en gegevensuitwisseling
In het zogenaamde [FHIR besluit](https://open.overheid.nl/documenten/ronl-72d9d941c7ee7ae2c58c236290e152b22939448d/pdf) is bepaald dat FHIR STU3/ zibs2027 en FHIR R4/zibs2020 dienen te worden gebruikt als uitwisselingsstandaarden. De European Health Data Space (EHDS) vereist FHIR R4 en europese core-profiles. Voor (de architectuur van) het dataplatform voor de paramedische zorg betekent dit dat uiteindelijk meerdere FHIR versies ondersteund zullen moeten worden. Zie ook [Standaarden](#standaarden)

In het kader van WEGIZ worden specifieke eektronische gegevensuitwisselingen verplicht gesteld en genormeerd. Op dit moment bestaat geen verplichting voor gegevensuitwisselingen die van toepassing zijn op de paramedische zorg.

## Grondslag voor het delen van gegevens
Voor het delen van gegevens is een grondslag nodig. Vaak wordt hierbij gedacht aan nadrukkelijke toestemming, zoals vereist vanuit de WABVPZ in het geval van een uitwisselingssysteem. Toestemming is echter lang niet altijd noodzakelijk. De [Factsheet toestemmingen](https://www.knmp.nl/sites/default/files/2021-12/factsheet-toestemmingen.pdf) van het ministerie van VWS geeft duidelijkheid over wanneer toestemming wel en niet vereist is, en over de vorm van de vereiste toestemming. Onder de European Health Data Space (EHDS) verandert de toestemmingsvereiste per 2027 in een recht op opt-out en een recht op toegangsbeperking van zorgverleners. Hoe deze rechten in de Nederlandse situatie zullen worden geïmplementeerd is nog grotendeels onduidelijk. Zie ook de brief aan de kamer betreffende [Opt-out EHDS en andere toezeggingen](https://open.overheid.nl/documenten/2efc8606-a4f0-4279-a2d2-2dc4fa31049a/file).

De hoofddoelen van het programma GUPZ betreffen het beschikbaar stellen van gezondheidsgegevens aan de patiënt zelf en de ondersteuning van elektronisch verwijzen. In beide gevallen is geen (nadrukkelijke) toestemming van de patiënt vereist en bestaat geen noodzaak voor implementatie van een opt-out of toegangsbeperking. Om deze reden, en vanwege onduidelijkheid over de implementatie van de door EHDS vereiste opt-out en toegangsbeperking, zal toestemming noch opt-out deel uitmaken van de start archirectuur van het dataplatform voor de paramedische zorg. 

De WAPVPZ vereist van zorgaanbieders dat zij bij de elektronische communicatie van gezondheidsgegevens een geverifieerd en gevalideerd BSN gebruiken ten behoeve van de identificatie van de patiënt. Verificatie betreft de controle dat demografische gegevens behoren tot een BSN. Validatie vindt plaats bij het eerste fysieke bezoek, waarbij aan de hand van een geldig identiteitsbewijs wordt gecontroleerd of de persoon voor de balie inderdaad degene is die is of wordt ingeschreven in het EPD. Voor (de architectuur van) het dataplatform voor de paramedische zorg betekent dit dat uitsluitend gezondheidsgegevens beschikbaar worden gesteld van patiënten die in het onderliggend PARIS beschikken over een geverifieerd en gevalideerd BSN. Voor gezondheidsgegevens die van andere zorgaanbieders worde ontvangen (zoals in het geval van een verwijzing) geldt dat de verificatie- en validatie verplichtingen de verantwoordelijkheid van die andere zorgaanbieder zijn.
  

# Proces
Een dataplatform voor de paramedische zorg is use case- (en dus proces) agnostisch. In het algemeen kan worden gesteld dat het dataplatform ondersteuning biedt aan:
- Het beschikbaar stellen van informatie uit het PARIS aan externe partijen, waaronder de patiënt zelf, met als doel het ondersteunen van primaire zorgprocessen, waaronder (maar niet gelimiteerd tot) verwijsprocessen, gezamenlijk behandelen in het kader van passende hybride netwerkzorg en participatie van de patiënt zelf en van niet-professionele zorgverleners
- Het ontvangen en verwerken van informatie van extere partijen in het PARIS, met als doel het ondersteunen van primaire zorgprocessen
- Het beschikbaar stellen van informatie uit het PARIS ten behoeve van secundair datagebruik, waaronder (maar niet gelimitieerd tot) wetenschappelijk onderzoek, kwaliteitsinformatie en capaciteitsmanagement.
  
Op de korte termijn zal echter worden gefocust op de [doelen](#doelstelling-programma-gupz) van van het programma GUPZ op het gebied van gegevensuitwisseling tussen paramedici en huisartsen, medisch specialisten en paramedici onderling, en op het gebied van uitwisseling met de patiënt via de Persoonlijke Gezondheidsomgeving (PGO) van de patiënt. Deze doelstellingen omvatten specifieke processen.

De afhandeling van processen binnen het PARIS zelf (zoals het verwerken en verzenden van verwijsinformatie of het klaarzetten van informatie voor het PGO) is geen onderdeel van de scope van het verwijsplatform.

## Digitaal verwijzen
Dit betreft het ontvangen en verwerken van een verwijzing van een huisarts, medisch specialist of andere paramedicus. 

## Melden van directe toegang
Dit betreft het informeren van de huisarts dat een patiënt direct, dus zonder verwijzing, hulp heeft gezocht bij de paramedische praktijk.

## Update door de paramedicus
Dit betreft tussentijdse rapportage van de paramedicus aan de verwijzer

## Update door de verwijzer
Dit betreft een update (waaronder annulering) ten aanzien van de verwijzing, een verzoek om informatie of de verstrekking van nadere informatie door de verwijzer aan de paramedicus

## Eindrapportage door de paramedicus
Dit betreft het beschikbaar stellen van eindrapportage aan de verwijzer door de paramedicus.

## Beschikbaar stellen van documenten, verslagen en behandelplan aan de patiënt
Dit betreft het beschikbaar stellen van documenten, rapportages en een afschrift van het behandelplan aan de patiënt zelf via diens PGO. Bijnzondere aandacht verdient versionering. Steeds wanneer een nieuwe versie van een document of behandelplan beschikbaar komt, dient deze als zodanig (als nieuwe versie van een bestaand document/ behandelplan) beschibaar te worden gesteld.

# Communicatiepatronen
Een dataplatform voor de paramedische zorg is use case- (en dus proces) agnostisch. In het algemeen kan worden gesteld dat het dataplatform ondersteuning biedt aan de volgende communicatiepatronen:

- Verzenden van PUSH berichten aan externe partijen (PUSH - uitgaand)
- Ontvangen van PUSH berichten van externe partijen (PUSH - imkomend)
- Verzenden van notificaties naar externe partijen en het verwerken van een bijbehorend PULL request (NOTIFIED-PULL - uitgaand)
- Ontvangen van notificaties van externe partijen en het uitvoeren van bijbehorend PULL request (NOTIFIED-PULL - inkomend)
- Ontvangen van verzoeken om informatie (PULL - ingaand)

Op de korte termijn zal echter worden gefocust op de voor de [doelen](#doelstelling-programma-gupz) van van het programma GUPZ benodigde communicatepatronen.

## Digitaal verwijzen
Digitale verwijzingen zullen op korte termijn worden geïmplementeerd als PUSH-bericht. Dit betekent voor het dataplatform voor de Paramedische zorg:

- Het ontvangen en verwerken van een PUSH-verwijsbericht
- Het versturen van een PUSH-verwijsbericht

Op de langere termijn zal PUSH verkeer stapsgewijs worden vervangen door NOTFIED-PULL verkeer. Dit betekent dat het dataplatform voor de Paramedische zorg op langere termijn naast de PUSH implementatie ook:

- Notificaties moet ontvangen en op basis van de notificatie bijbehorende verwijsinformatie op moet vragen bij de verwijzen
- Notificaties moet versturen en de bijbehorende verwijsinformatie terug moet geven bij een PULL request van de ontvanger

## Melden van directe toegang
Meldingen van directe toegang zullen op korte termijn worden geïmplementeerd als PUSH-bericht. Dit betekent voor het dataplatform voor de Paramedische zorg:

- Het versturen van een PUSH-melding directe toegang

## Update door de paramedicus
Updates zullen op korte termijn worden geïmplementeerd als PUSH-bericht. Dit betekent voor het dataplatform voor de Paramedische zorg:

- Het versturen van een PUSH-update

Op de langere termijn zal PUSH verkeer stapsgewijs worden vervangen door NOTFIED-PULL verkeer. Dit betekent dat het dataplatform voor de Paramedische zorg op langere termijn naast de PUSH implementatie ook:

- Notificaties moet versturen en de bijbehorende update terug moet geven bij een PULL request van de ontvanger


## Update door de verwijzer

Updates zullen op korte termijn worden geïmplementeerd als PUSH-bericht. Dit betekent voor het dataplatform voor de Paramedische zorg:

- Het ontvangen en verwerken van een PUSH-## Beschikbaar stellen van documenten, verslagen en behandelplan aan de patiënt

Op de langere termijn zal PUSH verkeer stapsgewijs worden vervangen door NOTFIED-PULL verkeer. Dit betekent dat het dataplatform voor de Paramedische zorg op langere termijn naast de PUSH implementatie ook:

- Notificaties moet ontvangen en op basis van de notificatie bijbehorende update op moet vragen bij de verwijzen

  
## Eindrapportage door de paramedicus
Eindrapportages zullen op korte termijn worden geïmplementeerd als PUSH-bericht. Dit betekent voor het dataplatform voor de Paramedische zorg:

- Het versturen van een PUSH-bericht met de eindrapportage

Op de langere termijn zal PUSH verkeer stapsgewijs worden vervangen door NOTFIED-PULL verkeer. Dit betekent dat het dataplatform voor de Paramedische zorg op langere termijn naast de PUSH implementatie ook:

- Notificaties moet versturen en de bijbehorende eindrapportage terug moet geven bij een PULL request van de ontvanger


## Beschikbaar stellen van documenten, verslagen en behandelplan aan de patiënt
Beschikbaar stellen van informatie aan het PGO zal (conform de betreffende MedMij gegevensdiensten) worden geïmplementeerd als PULL verzoeken. Dit betekent voor het dataplatform voor de Paramedische zorg:

- Het beantwoorden van PULL-verzoeken met de juiste (verwijzingen naar) PDF/A documenten.

# Informatie
Een dataplatform voor de paramedische zorg is use case agnostisch en omvat daarom potentieel alle informatieobjecten die ook in een PARIS worden vastgelegd, waaronder:
- Demografische- en identificerende gegevens van patiënten
- Verwijsinformatie
- Medicatie
- Diagnoses
- Onderzoeksresultaten
- Behandelinformatie
- Correspondentie en verslagen
- Metingen
- Psychosociale gegevens

Op de korte termijn zal echter worden gefocust op de [doelen](#doelstelling-programma-gupz) van van het programma GUPZ op het gebied van gegevensuitwisseling tussen paramedici en huisartsen, medisch specialisten en paramedici onderling, en op het gebied van uitwisseling met de patiënt via de Persoonlijke Gezondheidsomgeving (PGO) van de patiënt.

Informatieobjecten ten behoeve van digitaal verwijzen en ondersteunende processen worden gedefinieerd in overeenstemming met de richtlijn [HASP-P](https://viewers.nhg.org/haspviewer/).

Informatieobjecten worden daarnaast zoveel als mogelijk gedefinieerd in overeenstemming met de zorginformatiebouwstenen. Omdat de ondersteuning van digitaal verwijzen en de daaraan ondersteunende processen voorlopig zal worden gebaseerd op de ZorgDomein FHIR specificaties, is compliance met zorginformatiebouwstenen niet volledig haalbaar. Binnen het programma GUPZ wordt gestreefd naar standaardisatie van de verwijsstromen op basis van zibs2020. Zie ook [Standaarden](#standaarden). Dit betekent dat, in samenwerking met alle betrokken partijen, gestreeft wordt naar vervanging van de huidige ZorgDomein FHIR STU3 specificaties naar een FHIR R4/zibs2020 gebaseerde specificatie. 


## Informatieobjecten ten behoeve van digitaal verwijzen
Dit betreft in overeenstemming met de richtlijn [HASP-P](https://viewers.nhg.org/haspviewer/):
- Contextuele gegevens bij ieder bericht. 
Dit betreft onder andere identificatie van de patiënt, identificatie van de auteur, geadresseerde, eventuele kopie-aan en beheerder (van het systeem dat het bericht archiveert), gegevens betreffende het type bericht, datum en tijd van verzenden.
- Gegevens betreffende de verwijzing/ het consult. 
Dit betreft onder andere de urgentie en het type zorgpad (gestandaardiseerde of verkorte toegang), eventuele voorzieningen die nodig zijn bij het consult, reden en context van de verwijzing, het ingestelde beleid/ ingestelde behandeling en de omvang en aard van de actie of interventie die de verzender verwacht van de geconsulteerde en eventuele overige zaken van belang.
- Dossierinformatie
  Dit betreft onder andere relevante regels uit het journaal, episodelijst, behandelingen, medicatie, aanvullend onderzoek,risicovol leefgedrag, familieanamnese, psychosociale anamnes en Psychogeriatrisch onderzoek.

## Informatieobjecten ten behoeve van het melden van directe toegang
Dit betreft in overeenstemming met de richtlijn [HASP-P](https://viewers.nhg.org/haspviewer/):
- Contextuele gegevens bij ieder bericht. 
Dit betreft onder andere identificatie van de patiënt, identificatie van de auteur, geadresseerde, eventuele kopie-aan en beheerder (van het systeem dat het bericht archiveert), gegevens betreffende het type bericht, datum en tijd van verzenden.
- Gegevens betreffende de directe toegang tot de paramedische praktijk
Dit betreft onder andere de screening risicofactoren door paramedicus,de paramedische diagnose of conclusie,  het paramedisch beleid/ de ingestelde behandeling en eventuele overige zaken van belang.
- Dossierinformatie
  Dit betreft anamnese en resultaten van lichamelijk onderzoek

## Informatieobjecten ten behoeve van de update door de paramedicus
Dit betreft in overeenstemming met de richtlijn [HASP-P](https://viewers.nhg.org/haspviewer/):
- Contextuele gegevens bij ieder bericht. 
Dit betreft onder andere identificatie van de patiënt, identificatie van de auteur, geadresseerde, eventuele kopie-aan en beheerder (van het systeem dat het bericht archiveert), gegevens betreffende het type bericht, datum en tijd van verzenden.
- Gegevens bij de update
Dit betreft een eventuele vraagstelling of antwoord op een door de verwijzer gestelde vraag, het beleid of de ingestelde behandeling en eventuele overige zaken van belang.
- Dossierinformatie
  Dit betreft anamnese, resultaten van lichamelijk onderzoek, het behandelverloop/ resultaat, relevante uitslagen van beeldvormend-,functie- of aanvullend onderzoek en relevante uitslagen van consulten door derden

## Informatieobjecten ten behoeve van de update door de verwijzer
Dit betreft in overeenstemming met de richtlijn [HASP-P](https://viewers.nhg.org/haspviewer/):
- Contextuele gegevens bij ieder bericht. 
Dit betreft onder andere identificatie van de patiënt, identificatie van de auteur, geadresseerde, eventuele kopie-aan en beheerder (van het systeem dat het bericht archiveert), gegevens betreffende het type bericht, datum en tijd van verzenden.
- Gegevens bij de update
Dit betreft de reden van de update, het beleid of de ingestelde behandeling, een eventueel antwoord op een door de paramedicus gestelde vraag en eventuele overige zaken van belang.
- Dossierinformatie
Dit betreft dezelfde dossierinformatie als de informatie in het kader van het digitaal verwijzen

## Informatieobjecten ten behoeve van de eindrapportage door de paramedicus
Dit betreft in overeenstemming met de richtlijn [HASP-P](https://viewers.nhg.org/haspviewer/):
- Contextuele gegevens bij ieder bericht. 
Dit betreft onder andere identificatie van de patiënt, identificatie van de auteur, geadresseerde, eventuele kopie-aan en beheerder (van het systeem dat het bericht archiveert), gegevens betreffende het type bericht, datum en tijd van verzenden.
- Gegevens bij de eindrapportage
Dit betreft onder andere de oorspronkelijke vraagstelling/ reden verwijzing, de conclusie/ diagnose, aanbevelingen en follow-up (De in het kader van de behandeling gevraagde nazorg), afspraken met de patiënt en eventuele overige zaken van belang.
- Dossierinformatie
  Dit betreft anamnese, resultaten van lichamelijk onderzoek, het behandelverloop/ resultaat, relevante uitslagen van beeldvormend-,functie- of aanvullend onderzoek, relevante uitslagen van consulten door derden en psychososiale anamese.

## Informatieobjecten ten behoeve van het beschikbaar stellen van documenten, verslagen en behandelplan aan de patiënt
Dit betreft in overeenstemming met de [MedMij gegevensdienst PDF/A](https://informatiestandaarden.nictiz.nl/wiki/MedMij:V2020.01/OntwerpPDFA) de volgende zorginformatiebouwstenen (zib2017):
- Patiënt
- Zorgverlener
- Zorgaanbieder

Daarnaast worden de feitelijke documenten (in PDF/A formaat, BASE64 encoded) beschikbaar gesteld.


# Standaarden
open-GUPZ maakt onderscheid tussen twee verschillende typen standaarden:

- Use case agnostische standaarden
Dit betreft standaarden die dienen te worden toegepast ongeacht de specifieke use case. De te gebruiken standaarden worden vastgelegd in  [pas toe of leg uit -standaarden](/docs/standards/Pas-toe-leg-uit-standaarden.md)
- Use case specifieke standaarden.
Dit betreft standaarden die specifiek zijn voor de implementatie van een use case, vaak gerelateerd aan een afsprakenstelsel dat van toepassing is op die use case, zoals MedMij in het geval van de uitwisseling van informatie tussen PARIS en Persoonlijke Gezondheidsomgeving (PGO)

Op korte termijn zullen uitsluitend use case specifieke standaarden worden geïmplenteerd voor de use cases die voortvloeien uit de doelstellingen van het programma GUPZ, te weten verwijzen (en ondersteunende processen) en het beschikbaarstellen van documenten en afschriften aan het PGO.

## FHIR versies
open-GUPZ volgt waar mogelijk het [FHIR besluit](https://open.overheid.nl/documenten/ronl-72d9d941c7ee7ae2c58c236290e152b22939448d/pdf), met een baseline van minimaal FHIR STU3 (op basis van zibs 2017) en maximaal FHIR R4 (op basis van zibs 2020). Het dataplatform voor de paramedische zorg zal op korte termijn (periode tot in ieder geval eind 2027) alleen FHIR STU3 ondersteunen, omdat de te ondersteunen use cases uitsluitend gebruik maken van FHIR STU3. Op termijn zal geleidelijk worden overgestapt op FHIR R4. Dit betekent dat het dataplatform voor de paramedische zorg uiteindelijk minimaal twee FHIR versies tegelijkertijd dient te ondersteunen.

## Standaarden specifiek voor verwijzen
Het dataplatform voor de paramedische zorg zal op korte termijn (periode tot in ieder geval eind 2027) de [FHIR STU3 specificaties van ZorgDomein](https://integrator.zorgdomein.com/fhir-specs/) implementeren ter ondersteuning van het verwijzproces. 

Het programma GUPZ streeft op lange termijn naar de toepassing van een nationale standaard voor verwijzen, met in ieder geval de volgende kenmerken:

- Gebaseeerd op FHIR R4 en zibs2020
- Beheerd door een onafhankelijke standaardisatie organisatie zoals Nictiz
- Bij voorkeur gebaseerd op het NOTIFIED-PULL communicatiepatroon in plaats van het door ZorgDomein gehanteerde PUSH patroon.

Een betaversie van [de informatiestandaard paramedische zorg](https://nictiz.nl/informatiestandaarden/paramedische-zorg/) is reeds ontwikkeld door Nictiz. Toepassing van deze standaard op schaal is echter in de praktijk pas haalbaar wanneer verwijzers (voornamelijk huisartsen) digitale verwijzingen plaatsen op basis van de standaard. Op dit moment wordt in nagenoeg alle gevallen verwezen met behulp van ZorgDomein en dus op basis van de [FHIR specificaties van ZorgDomein](https://integrator.zorgdomein.com/fhir-specs/). Vanuit het programma GUPZ zal in samenwerking met ZorgDomein, Nictiz en andere stakeholders worden aangestuurd op harmonisatie van de ZorgDomein specificaties en de nationale standaard, en dus naar ondersteuning van FHIR R4 en NOTIFIED-PULL.

## Standaarden specifiek voor het beschikbaar stellen van documenten, verslagen en behandelplan aan de patiënt
Ten behoeve van het beschikbaar stellen van documenten aan het PGO van de patiënt implementeert het dataplatform voor de paramedische zorg de [FHIR specificaties van de MedMij gegevensdienst PDF/A](https://informatiestandaarden.nictiz.nl/wiki/MedMij:V2020.01/FHIR_PDFA). Hierbij dient te worden aangetekend dat het dataplatform wel de gegevensdienst implementeert,maar niet alle MedMij specifieke afspraken uit het [MedMij afsprakenstelse](https://afsprakenstelsel.medmij.nl/asverplicht/mmverplicht/?l=nl) die gelden voor de rol Dienstverlener Zorgaanbieder (DVA). De MedMij afspraken die gelden voor de DVA zullen worden geïmplementeerd door een op het dataplatform aangesloten DVA. Zie ook het principe (Seperation of concerns)[#seperation-of-concerns].

## Standaarden specifiek voor de inhoud van documenten, verslagen en het behandelplan
De inhoud van documenten zal sectorbreed worden gespecificeerd door het programma GUPZ. Templates voor deze documenten worden opgenomen in de open-GUPZ repository, onder ['templates'](/templates).

## Terminologie
Door het programma GUPZ worden waardenlijsten en referentiesets ontwikkeld ten behoeve van:
- Het coderen van documenttypes
Het documenttype wordt opgenomen in de DocumentReference.class. Dit codeableconcept heeft als binding 'Example', hetgeen feitelijk betekent dat iedere code kan worden gebruikt. Door GUPZ zal een waardenlijst worden opgesteld met codes bij voorkeur vanuit de door [Nictiz aangegeven waardenlijst](https://decor.nictiz.nl/pub/documentuitwisseling/docs-html-20241119T114146/voc-2.16.840.1.113883.2.4.3.11.60.106.11.5-2015-12-01T102506.html), indien nodig aangevuld met andere SNOMED-CT of LOINC coderingen.
- Het coderen van verwijsproducten
Door het programma GUPZ wordt gestreeft naar harmonisatie van de codering van verwijsproducten/ redenen voor de gehele paramedische sector
>[!WARNING]
>Saskia T...wat verder nog?

Referentiesets en waardenlijsten worden opgenomen in ['terminology'](/templates).

# Architectuur patronen
PARIS leveranciers onderkennen twee alternatieve software architecture patterns voor het dataplatform voor de Paramedishe Zorg:

- Sync-agent
Data uit het PARIS wordt (near) realtime gesynchroniseerd naar een FHIR store en van daaruit beschikbaar gesteld. Inkopende data wordt vanuit de FHIR store waar nodig  (near)realtime gesynchroniseerd naar het PARIS.
Dit patroon wordt verder uitgewerkt in [FHIR-Facade-pattern.md](/docs/architecture/FHIR-Facade-pattern.md)
- FHIR Facade
Een FHIR facade is een FHIR interface rechtstreeks op het PARIS. De Facade vertaalt inkomende FHIR requests naar PARIS-specifieke datarequests en transleert PARIS-specifieke datastructuren en -formaten naar FHIR formaat.
Dit patroon wordt verder uitgewerkt in [Sync-agent-pattern.md](/docs/architecture/Sync-agent-pattern.md)

Beide patronen kennen hun eigen voor- en nadelen en kunnen desgewenst worden gecombineerd. 

# Privacy en Informatiebeveiliging
open-GUPZ gaat uit van [privacy by design](#privacy-by-design) en [security in depth](security-in-depth) en borgt de onder die principes en uitgangspunten beschreven richtlijnen.

Overige specifieke maatregelen zijn:

## Beveiliging van netwerkverker
open-GUPZ vereist mutual TLS (mTLS) verbindingen tussen het dataplatform voor de paramedische zorg en aangesloten externe systemen (waaronder DVA, Verwijsplatform en NIS). TLS verbindingen dienen te voldoen aan de [ICT-beveiligingsrichtlijnen voor TLS](https://www.ncsc.nl/transport-layer-security-tls/v21-tls). open-GUPZ vereist dat TLS instellingen minimaal voldoen aan veiligheidniveau 'Voldoende'. In het geval van veiligheidniveau 'Voldoende' dient de beheerder van het dataplatform aan te geven op welke wijze en binnen welke termijn de instelling zal voldoen aan veiligheidsniveau 'Goed'.

## Authenticatie op application niveau
Authenticatie van het aangesloten systeem (zoals een DVA, Verwijsplatform of NIS) en de eindgebruiker vindt plaats aan de hand van JSON Web Tokens (JWT) op basis van de [ZorgDomein specificatie voor application level security](https://integrator.zorgdomein.com/fhir-specs/security/#application-level-security-json-web-tokens), aangevuld met het BSN van de patiënt waarvoor het verzoek (FHIR request) wordt gedaan.

## Veilige exploitatie
Het dataplatform voor de paramedische zorg kan rechstreeks  worden benaderd vanaf een publiek netwerk (zoals het internet). Waarborgen van een veilige exploitatie is daarom noodzakelijk. 

Om aan te sluiten op MedMij dienen deelnemers (paramedische praktijken) in het bezit te zijn van een geldige NEN 7510-certificering. 

Maatregelen (controls) voor veilige exploitatie van een dataplatform vooor de paramedische zorg vallen onder [beheer](#beheer) en zijn de verantwoordelijkheid van de aanbieder van het dataplatform, doorgaans een PARIS leverancier. Beheerders/ aanbieders van een dataplatform voor de paramedische zorg dienen te voldoen aan NEN7510 en NEN7513. Certificering is niet verplicht, maar is voor grote organisaties (50> medewerkers, 10.000.000> jaaromzet) onontkomelijk om aantoonbaar te voldoen aan NIS2. 

Door de verwerkingsverantwoordelijke (de paramedische praktijk) zal een Data Privacy Impact Assessment moeten worden uitgevoerd om risico's in kaart te brengen en eventueel aanvullende maatregelen te nemen om veilige exploitatie te borgen. Een lijst van risico's en bijbehorende mogelijke mitigerende maatregelen is opgenomen in [DPIA.md](/docs/policies/DPIA.md). Bewezen maatregelen van de beheerder/ aanbieder van een dataplatform voor de paramedische zorg (zoals een NEN 7510 certificering of periodieke beveiligingsaudit) kunnen worden opgenomen als mitigerende maatregel. 

Aanbeiders/ beheerders van een dataplatform voor de Paramedische zorg laten tenminste jaarlijks een greybox penetratietest uitvoeren door een EDP auditor op externe koppelvlakken. Ook bij grootschalige wijzigingen of herbouw wordt een greybox pentest uitgevoerd. De scope van de penetratietests is:

- De OWASP API top 10
- [ICT-beveiligingsrichtlijnen voor TLS](https://www.ncsc.nl/transport-layer-security-tls/v21-tls)
- Voor zover van toepassing: [ICT-beveiligingsrichtlijnen voor webapplicaties](https://www.ncsc.nl/ict-beveiligingsrichtlijnen-webapplicaties)

# Beheer
Een dataplatform voor de paramedische zorg wordt aangeboden als SaaS dienst, en wordt operationeel beheerd door de aanbeider van de SaaS dienst, op basis van een met de paramedische praktijk overeengekomen Service Level Agreement (SLA).




