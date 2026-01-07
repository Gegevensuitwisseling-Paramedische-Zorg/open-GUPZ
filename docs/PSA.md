# Project Start Architectuur - Dataplatform voor de Paramedische Zorg
## Inleiding
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
- Een uitwerking van verschillende oplossingsrichtingen in de vorm van software architecture patterns en 'implementatieprofielen'
- Een lijst met 'pas toe of leg uit' standaarden 
- Specificaties van FHIR API's voor een dataplatform voor de paramedische zorg. 
>[!WARNING]
>How to connect to simplifier? OpenAPI?
- Eisen aan aansluitvoorwaarden voor partijen die op een paramedisch dataplatform aan willen sluiten
- Optioneel source code voor gezamenlijk ontwikkelde onderdelen van een dataplatform voor de paramedische zorg
- Specificaties van documenttypes voor het beschikbaarstellen/ uitwisselen van ongestructureerde gegevens
- Standaard coderingen (SNOMED refsets)
- Minimale functionele requirements/ capablities op het gebied van verwijzen en het beschikbaar stellen van informatie aan patiënten

# Organisatie/ stakeholders
Geef hier een eerste indicatie van de (rol van) stakeholders die betrokken zijn bij (de oplossing voor) het vraagstuk. 
## Projectorganisatie
>[!WARNING]
>Saskia T...wil jij deze oppakken?
## Samenwerkingsafspraken

REAME.md
## Stakeholdermanagement

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
open-GUPZ ontwikkelt een lijst van !['pas toe of leg uit' -standaarden ](/Pas toe leg uit standaarden.md) voor de ontwikkeling van een dataplatform voor de Paramedische Zorg. Het gebruik van open standaarden bevordert de interoperabiliteit en daarmee de communicatie en samenwerking tussen verschillende zorginformatiesystemen en -applicaties. Het gebruik van open standaarden is daarmee een belangrijke voorwaarde voor het creeren van een gelijk speelveld. 'Pas toe of leg uit' -standaarden zullen worden gebruikt op alle niveau's van het Nictiz interoperabiliteitsmodel.

## Gebruik van openbare architecture patterns en implementatieprofielen
open-GUPZ ontwikkelt software architecture patterns en implementatieprofielen als blauwdruk voor de implementatie van een dataplatform voor de Paramedische Zorg. Gebruik van architecture patterns en implementatieprofielen voorkomt of beperkt leverancier-specifieke implementatie van de verplichte standaarden en het ontstaan van monolitische 'totaaloplossingen'. Het gebruik van architecture patterns en implementatieprofielen is daarmee een belangrijke voorwaarde voor het creeren van een gelijk speelveld. 

## Open innovatie en samenwerking 
PARIS leverenciers willen samenwerken, onderling en met andere stakeholders, en gezamenlijk de ideeen, technologieen en kennis ontwikkelen die nodig is voor de realisatie van een state of the art dataplatform voor de Paramedische Zorg. Alles dat wordt ontwikkeld wordt publiek gedeeld in De open-GUPZ repository en website.

## Seperation of concerns
De scope van het dataplatform voor de Paramedische Zorg is duidelijk afgebakend: Het leveren van fijnmazige, use-case agnostische, FHIR gebaseerde system API's op het Paramedisch Informatiesysteem (PARIS). 'Seperation of concerns' wil zeggen dat het dataplatform ontkoppeld is van use-case/ afsprakenstelsel specifieke API's (process API's) en API clients (apps). Afbakening voorkomt het ontstaan van monolotische 'totaaloplossingen' en leverancierspecifieke implementaties van standaarden. 

![Three layer API architecture](/assets/3_layer_api_architecture.jpg)

## Hergebruik
open-GUPZ streeft naar maximaal hergebruik van alles wat door de deelnemende PARIS leveranciers wordt ontwikkeld. Specificaties worden zo generiek en herbruikbaar mogelijk ontworpen. Principes als 'seperation of concerns', 'gebruik van open standaarden' en 'gebruik van openbare software archirecture patterns en implementatieprofielen' zijn hiervoor een belangrijke voorwaarde.

## Reductie van complexiteit
PARIS leveranciers willen de complexiteit van de door hen ontwikkelde systemen beperken. Door 'seperation of concerns' kan het gebruik technologiën en implementatieprofielen die specifiek zijn voor een bepaald afsprakenstelsel zoals MedMij, binnen het dataplatform worden voorkomen of beperkt. Door scheiding van het dataplatform van het PARIS zelf, wordt voorkomen dat de complexiteit van het PARIS toeneemt.
 Door open innovatie en samenwerking kunnen complexe componten van het dataplatform gezamenlijk worden gespecificeerd en/ of ontwikkeld. 

## Just enough architecture
open-GUPZ ontwikkelt software archtecture patterns met als doel om verschillen bij de implementatie van standaarden te voorkomen of beperken. Het detailniveau van de ontwikkelde architectuur is precies voldoende voor dat doen, en niet meer dan dat. Teveel detail zal de implementatievrijheid van PARIS leveranciers en andere stakeholders onnodig beperken.

## Implementatievrijheid 
PARIS leveranciers streven naar implementatievrijheid. Dat wil zeggen dat open-GUPZ zoveel mogelijk ontwikkekplatform en -taal agnostische specificaties en patterns zal bevatten. Eventuele opensource implentaties kunnen dienen als referentie-implementatie. 

## Make, join or buy
Bij de ontwikkeling van een dataplatform voor de Paramedische Zorg worden alleen componenten ontwikkeld die niet opensource of commercieel, tegen een redelijk tarief, beschikbaar zijn. Make, join or buy beslissingen worden gezamenlijk gemaakt en gedocumenteerd.

## Privacy by design
open-GUPZ hanteert de 'privacy by design ontwerpfilosofie', die vereist dat privacybescherming vanaf het begin af aan meegenomen wordt bij het ontwerpen en bouwen van nieuwe systemen. Concreet betekent dit dat op de 'privacy ontwerp strategieën' uit![Het blauwe boekje](https://www.cs.ru.nl/~jhh/blauwe-boekje.html) zullen worden toegepast op het ontwerp van het dataplatform voor de Paramedische Zorg.

## Security in depth
open-GUPZ hanteert de ![ICT-beveiligingsrichtlijnen voor webapplicaties](https://www.ncsc.nl/ict-beveiligingsrichtlijnen-webapplicaties) van het Nationaal Cyber Security Center bij het opstellen van:
- Software arcitecture patterns (richtlijnen voor de laag 'webapplicaties')
- Implementatieprofielen voor de inrichting van platformen, webservers en netwerken (richtlijnen voor de lagen 'Platform en webservers' en 'Netwerken')

## Waarde voor eindgebruikers
De bovenstaande uitgangspunten en principes zijn ondergeschikt aan de waarde voor eindgebruikers. Mitz beargumenteerd (pas toe of leg uit) kan worden afgeweken van de bovenstaande uitgangspunten en principes indien dit aantoonbaar bijdraagt aan de waarde voor eindgebruikers.

# Juridische context

## Grondslag voor de verwerking van gegevens
Een dataplatform voor de Paramedische Zorg is een middel bij de verwerking van (bijzondere) persoonsgegevens en valt daarom onder de invloedssfeer van de Algemene Verordening Gegevensbescherming (AVG). Dit betekent in ieder geval dat de aanbieder van het dataplatform verwerker is en verwerking alleen is toegestaan voor zover deze is overeengekomen in een verwerkersovereenkomst met de verwerkingsverantwoordelijke, zijnde de paramedische praktijk. De grondslag voor verwerking van deze gegevens is dat zij nodig zijn voor het uitvoeren van de behandeling. Zorginstellingen zijn uitgezonderd van het verbod op het verwerken van gegevens over gezondheid, enkel voor zover de verwerking noodzakelijk is met het oog op een goede behandeling of verzorging van de betrokkene dan wel het beheer van de betreffende instelling of beroepspraktijk (artikel 30 lid 3 UAVG).  

Een dataplatform voor de Paramedische Zorg verwerkt gegevens afkomstig uit het onderliggende PARIS van één paramedische praktijk. Dit betekent dat alle door het dataplatfom verwerkte gegevens net zo noodzakelijk zijn met het oog op goede behandeling als de gegevens in het PARIS. Doel(beschikbaar stelle) en middelen (dataplatform) veranderen wel en dienen te worden verwoord in de verwerkersovereenkomst.

Een dataplatform voor de Paramedische Zorg kan worden gezien als Elektronisch Uitwisselingssysteem zoals bedoeld in de Wet aanvullende Bepalingen Verwerking Persoonsgegevens in de Zorg (WABVPZ). Dit betekent dat de vanuit de WABVPZ gestelde eisen aan zo'n uitwisselingssysteem in principe ook gelden voor het dataplatform voor de Paramedische Zog. Dit betreft vooral eisen op het gebied van de [rechten van de patiënt](#rechten-van-de-betrokkene) en op het gebied van [gegevensdeling](#grondslag-voor-het-delen-van-gegevens).

## Rechten van de betrokkene
De AVG stelt eisen ten aanzien van de rechten van de betrokkene (de patiënt). Het dataplatform voor de Paramedische Zorg ondersteunt bij de implementatie van sommige van deze eisen:
- De eis op dataportabiliteit. Het dataplatform stelt data beschikbaar in een standaard (FHIR) formaat. Daarmee is data portable
- Recht op inzage. Het dataplatform stelt data beschikbaar aan de patiënt zelf en ondersteunt daarmee diens recht op inzage.

Op grond van de Wet Aanvullende Bepalingen Verwerking Persoonsgegevens in de Zorg (WABVPZ) heeft de patiënt daarnaast recht op een eletronisch afschrift van gegevens. Omdat het dataplatform voor de Paramedische Zorg gegevens elektronisch/ digitaal beschikbaar stelt, ondersteunt zij bij de implementatie van dit recht.

Voor het recht op gegevenswissing en rectificatie en aanvulling (AVG), geldt dat het dataplatform voor de Paramedische Zorg het onderliggende PARIS als bron van gegevens gebruikt. Gegevens die worden gerectificeerd, aangevuld of gewist in het onderliggende PARIS, zullen automatisch moeten worden gerectificeerd, aangevuld of gewist. De architectuur van het dataplatform dient dit te waarborgen.

Het recht op inzage van logging (WABVPZ) vereist dat patiënten kosteloos een (elektronisch) afschrift op kunnen vragen, waarin staat wie wanneer informatie heeft verstrekt, ingezien of opgevraagd in het elektronisch uitwisselingssysteem. De architectuur van het dataplatform dient te borgen dat een dergelijk elektronisch afschrift eenvoudig kan worden aangeleverd.

Op grond van de AVG heeft de betrokkene recht op informatie over doel en middelen van de verwerking. Deze informatie dient door de verwerkingsverantwoordelijke (de paramedische praktijk) te worden verstrekt. Vanuit open-GUPZ zal een standaard ![privacyverklaring](/privacyverklaring.md) worden ontwikkeld die kan worden opgenomen in de website van de paramedische praktijk.

## Niet functionele eisen op het gebied van privacy en security
De AVG stelt ontwerpeisen in het kader van privacy (privacy by design, privacy by default) en security (passende maatregelen). Binnen open-GUPZ worden deze eisen gedekt vanuit de principes [privacy by design](#privacy-by-design) en [security in depth](#security-in-depth).

De Verordening betreffende elektronische identificatie en vertrouwensdiensten (eIDAS) stelt eisen aan de betrouwbaarheid van authenticatie door personen (zorgverleners, patiënten). open-GUPZ gaat uit van [seperation of concerns](#Seperation of concerns). De authenticatie van personen is geen 'concern' van het dataplatform maar een 'concern' van de brokers die de use case specifieke process API's aanbieden.

De AVG verplicht de verwerkingsverantwoordelijke om een data protection impact assessment (DPIA) uit te voeren als een gegevensverwerking waarschijnlijk een hoog privacyrisico oplevert voor de mensen van wie de organisatie gegevens verwerkt. De verwerking van gegevens over gezondheid door een dataplatform kan worden gezien als een risicovolle verwerking waarvoor een DPIA verplicht is. open-GUPZ ontwikkelt een  ![factsheet met risico's en mitigerende maatregelen](/DPIA.md)ten behoeve van het uitvoeren van een DPIA.

Naleving van NEN7510, NEN7513 en NEN712 is verplicht en verankerd in onder andere de WABVPZ, het besluit elektronische gegevensverwerking voor zorgaanbieders (Begz) en Regeling Gebruik Burgerservicenummer. Certificering van NEN7510 is niet verplicht, maar de Inspectie Gezondheidszorg en Jeugd (IGJ) ziet toe op naleving en verwacht dat zorgaanbieders aantoonbaar werken volgens de NEN7510 om de continuïteit en veiligheid van zorg te waarborgen. Naleving van NEN7510 is verplicht voor alle zorgaanbieders en staat los van het eventuele gebruik van een dataplatform voor de Paramedische Zorg. Vanuit de WABPVPZ is naleving van NEN7512 en NEN7513 verplicht. Voor deze normen bestaat geen certificering. Consequenties voor (de architectuur van) het dataplatform voor de Paramedische Zorg zijn onder andere:

- Audittrail dient aantoonbaar te voldoen aan de NEN7513. De architectuur van het dataplatform dient dit te borgen.
- Of voldaan dient te worden aan NEN7512 is afhankelijk van de use case (niet voor MedMij bijvoorbeeld). NEN7512 compliance is daarom niet in scope van het dataplatform voor de Paramedische Zorg, maar wel in scope voor de brokers die de use case specifieke process API's aanbieden.
- [Beheer](#beheer) van het dataplatform dient te worden ingericht in overeenstemming met NEN7510

De  Network and Information Security Directive 2 (NIS2), in Nederland geïmplemeteerd door de Cyberbeveiligingswet(CBW) vereist implementatie van strenge beveiligingsnormen voor organisaties groter dan 50 personen of met een jaarlijkse omzet van meer dan 10 miljoen. NIS2 is van toepassing op groeiend aantal PARIS leveranciers. Er bestaat geen specifieke NIS2 certificering, maar ISO27001 en NEN7510 certificering sluiten nauw aan bij de eisen uit NIS2. Voor het dataplatform voor de Paramedische Zorg worden de volgende maatregelen voorzien:

- [Beheer](#beheer) van het dataplatform dient te worden ingericht in overeenstemming met NEN7510
- [Security in depth](#security-in-depth) wordt ingericht in overeenstemming met de beveiligingsrichtlijnen voor webapplicaties van het Nationaal Cyber Security Center)
  
## Niet functionele eisen op het gebied van databeschikbaarheid en gegevensuitwisseling
In het zogenaamde [FHIR besluit](https://open.overheid.nl/documenten/ronl-72d9d941c7ee7ae2c58c236290e152b22939448d/pdf) is bepaald dat FHIR STU3/ zibs2027 en FHIR R4/zibs2020 dienen te worden gebruikt als uitwisselingsstandaarden. De European Health Data Space (EHDS) vereist FHIR R4 en europese core-profiles. Voor (de architectuur van) het dataplatform voor de Paramedische Zorg betekent dit dat uiteindelijk meerdere FHIR versies ondersteund zullen moeten worden. Zie ook [Standaarden](#standaarden)

In het kader van WEGIZ worden specifieke eektronische gegevensuitwisselingen verplicht gesteld en genormeerd. Op dit moment bestaat geen verplichting voor gegevensuitwisselingen die van toepassing zijn op de Paramedische Zorg.

## Grondslag voor het delen van gegevens
Voor het delen van gegevens is een grondslag nodig. Vaak wordt hierbij gedacht aan nadrukkelijke toestemming, zoals vereist vanuit de WABVPZ in het geval van een uitwisselingssysteem. Toestemming is echter lang niet altijd noodzakelijk. De ![Factsheet toestemmingen](https://www.knmp.nl/sites/default/files/2021-12/factsheet-toestemmingen.pdf) van het ministerie van VWS geeft duidelijkheid over wanneer toestemming wel en niet vereist is, en over de vorm van de vereiste toestemming. Onder de European Health Data Space (EHDS) verandert de toestemmingsvereiste per 2027 in een recht op opt-out en een recht op toegangsbeperking van zorgverleners. Hoe deze rechten in de Nederlandse situatie zullen worden geïmplementeerd is nog grotendeels onduidelijk. Zie ook de brief aan de kamer betreffende ![Opt-out EHDS en andere toezeggingen](https://open.overheid.nl/documenten/2efc8606-a4f0-4279-a2d2-2dc4fa31049a/file).

De hoofddoelen van het programma GUPZ betreffen het beschikbaar stellen van gezondheidsgegevens aan de patiënt zelf en de ondersteuning van elektronisch verwijzen. In beide gevallen is geen (nadrukkelijke) toestemming van de patiënt vereist en bestaat geen noodzaak voor implementatie van een opt-out of toegangsbeperking. Om deze reden, en vanwege onduidelijkheid over de implementatie van de door EHDS vereiste opt-out en toegangsbeperking, zal toestemming noch opt-out deel uitmaken van de start archirectuur van het dataplatform voor de Paramedische Zorg. 

De WAPVPZ vereist van zorgaanbieders dat zij bij de elektronische communicatie van gezondheidsgegevens een geverifieerd en gevalideerd BSN gebruiken ten behoeve van de identificatie van de patiënt. Verificatie betreft de controle dat demografische gegevens behoren tot een BSN. Validatie vindt plaats bij het eerste fysieke bezoek, waarbij aan de hand van een geldig identiteitsbewijs wordt gecontroleerd of de persoon voor de balie inderdaad degene is die is of wordt ingeschreven in het EPD. Voor (de architectuur van) het dataplatform voor de Paramedische Zorg betekent dit dat uitsluitend gezondheidsgegevens beschikbaar worden gesteld van patiënten die in het onderliggend PARIS beschikken over een geverifieerd en gevalideerd BSN. Voor gezondheidsgegevens die van andere zorgaanbieders worde ontvangen (zoals in het geval van een verwijzing) geldt dat de verificatie- en validatie verplichtingen de verantwoordelijkheid van die andere zorgaanbieder zijn.
  

# Proces
Nader Uitwerken

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





