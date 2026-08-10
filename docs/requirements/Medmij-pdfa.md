---
title: Platform specifieke eisen voor de MedMij Documenten dienst (PDF/A)
layout: template
filename: Medmij-pdfa.md
--- 


# Het onderscheid tussen dossiersamenvattingen en 'correspondentie en berichten'
Binnen openGUPZ wordt onderscheid gemaakt tussen twee verschillende typen documenten:

- Dossiersamenvattingen.   
Dit betreft een statische weergave van (een deel van) het dossier op een gegeven moment in de tijd, ook wel een snapshot van het dossier genoemd. Dossiersamenvattingen worden door het PARIS gegenereerd uit de beschikbare dossierinformatie. De gegenereerde tekst kan niet door de eindgebruiker worden aangepast of aangevuld. Alleen de brongegevens (het dossier) kunnen worden aangepast, waarna een nieuw document kan worden gegenereerd, of een nieuwe versie van het document kan worden gegenereerd.

- Correspondentie en berichten.   
Dit betreft documenten die (deels) kunnen worden gegenereerd uit beschikbare dossierinformatie, maar waarvan de gegenereerde tekst door de eindgebruiker kan worden aangepast dan wel aangevuld.

# Paramedie specifieke eisen aan het beschikbaarstellen van dossiersamenvattingen via het PGO #
Het genereren en beschikbaar stellen aan het PGO van een behandelplan is als voorbeeld uitgewerkt, onderstaande functionele eisen gelden echter voor alle dossiersamenvattingen die aan het PGO beschikbaar worden gesteld, dus ook bijvoorbeeld voor paramedische diagnose en het diagnostiekplan. Functionele eisen raken potentieel zowel de werking van het PARIS als van het dataplatform.
 
### Vastlegging in het PARIS voldoet aan de door de beroepsgroepen vastgestelde document-templates ###
Alle velden die als verplicht zijn opgenomen in de document-templates kunnen in het PARIS door de paramedicus worden vastgelegd. 
Het template vormt de minimale basis voor registratie en is de norm voor output (naar brieven en documenten). Dit wil zeggen dat gegenereerde documenten geen velden bevatten die niet in het template zijn gedefinieerd.  

Als er een PDF/A genereert wordt en een sjabloonveld is niet gevuld, dan wordt dit veld niet opgenomen in de PDF/A die genereert wordt voor de uitwisseling, zodat er geen lege velden in de PDFA worden opgenomen.  

> [!IMPORTANT]
> Templates worden gespecificeerd binnen openGUPZ en zijn te vinden in [templates](/docs/templates/index.md)


### Voor alle gegenereerde dossiersamenvattingen wordt een status bijgehouden ###
Behandelplannen en de overige documenten hebben een status. De status van documenten is in het PARIS in te zien. Het betreft de volgende statussen:

- Concept:
  Dit is een behandelplan (document) dat door paramedicus gemaakt of gegenereert is (bijvoorbeeld op basis van een bestaand behandelplan), maar dat nog niet als definitief is gemarkeerd.  Naast de status wordt ook de datum vastgelegd waarop het behandelplan (het document) gemaakt is.
- Actueel:  
Dit is de actuele versie van het behandelplan, dat de basis vormt voor de behandeling. Deze status wordt bij het behandelplan (het document) vastgelegd zodra de paramedicus het document als 'definitief' markeert. Naast de status wordt ook de datum vastgelegd waarop het behandelplan (het document) als definitief werd gemarkeerd en wordt een eventuele geldigheidsduur vastgelegd  
- Gearchiveerd:  
  Dit is een behandelplan (document) dat definitief was, maar wordt vervangen door een nieuwe versie van het behandelplan. Wanneer een concept behandelplan (document) definitief wordt gemaakt, wordt een eventuele bestaande als definitief gemarkeerde versie gearchiveerd. Naast de status wordt ook de archiefdatum vastgelegd.
- Foutief:
  Dit is een document dat als 'definitief' is gemarkeerd (en dus de status 'actueel' heeft) maar dat fouten bevat. Een dergelijk document kan de status 'Foutief' krijgen.

### dossiersamenvattingen met de status 'Concept' worden niet aan het PGO beschikbaargesteld ###
Documenten worden pas beschikbaar gesteld aan het PGP zodra zij als definitief gemarkeerd worden en de status 'actueel' krijgen. Een document met de status 'actueel' kan worden vervangen door een nieuwe versie zodra deze als 'definitief' gemarkeerd wordt. De vervangen versie krijgt automatisch de status 'gearchiveerd' en mag als zodanig aan het PGO beschikbaar gesteld worden.

### dossiersamenvattingen met de statis 'Foutief' mogen worden verwijderd als zij nooit ingezien zijn
Wanneer een document de status 'Foutief' krijgt mag zij worden teruggetrokken voor inzage in het PGO mits met zekerheid kan worden vastgesteld dat het document nooit door iemand is ingezien. 

### dossiersamenvattingen zijn uitsluitend gebaseerd op dossiervelden en worden nooit handmatig aangepast of uitgebreid
Voor dossiersamenvattingen geldt dat als het onderliggende dossier wordt aangepast, documenten met de openGUPZ status 'Actueel' die op dezelfde dossiervelden zijn gebaseerd, de status openGUPZ status 'Gearchiveerd' krijgen, zodra het nieuwe document de status 'Actueel' krijgt Het nieuwe 'Actuele' document mag verwijzen naar de gearchiveerde versie via het DocumentReference.relatesTo veld. In dat geval wordt de HL7 FHIR codering 'replaces ' gebruikt.

### Een wijziging in een onderliggend dossierveld leidt altijd tot een nieuwe versie van de dossiersamenvatting ###
Voor dossiersamenvattingen geldt dat als het onderliggende dossier wordt aangepast:

- Een nieuw document wordt aangemaakt met de status 'concept'
- documenten met de openGUPZ status 'Actueel' die op dezelfde dossiervelden zijn gebaseerd, de status openGUPZ status 'Gearchiveerd' krijgen, zodra het nieuwe document de status 'Actueel' krijgt. 

### De behandelaar kan de versiehistorie van een dossiersamenvatting inzien ###
Standaard ziet de behandelaar de actuele versie (status Actueel) van dossiersamenvattingen. Het Paris biedt echter de mogelijkheid om andere versies van dossiersamenvattingen (met de status Concept of Archief) in te zien.

### Alleen documenten die de paramedicus zelf heeft gegenereerd worden aan het PGO beschikbaargesteld ###
Alleen behandelplannen die de paramedicus zelf schrijft en definitief maakt zijn beschikbaar voor uitwisseling naar PGO. PDF/A die de paramedicus van derden ontvangen heeft, denk aan de verwijsbrief bijv. worden niet via het PARIS beschikbaar gesteld voor PGO. De patiënt  kan dit opvragen via het PGO en de zorgaanbieder die dit opgesteld heeft.

### Niet ingevulde velden worden niet opgenomen in de dossiersamenvattingen ###
Als er een dossiersamenvatting gegeneerd wordt en een sjabloonveld is niet ingevuld, dan wordt dit veld niet opgenomen in de PDFA die gegeneerd wordt voor de uitwisseling, zodat er geen lege velden in de PDFA staan.

### Een client kan meerdere actuele behandelplannen hebben indien deze in behandeling is voor verschillende diagnoses ###
Als paramedicus wil ik meerdere parallelle actuele behandelplannen in het PARIS kunnen hebben, gekoppeld aan verschillende diagnoses, als een patient voor meerdere diagnoses in behandeling is.

### Iedere dossiersamenvatting bevat een briefhoofd met identificatie van de auteur en de patiënt ###
Alle PDF/A documenten bevatten een briefhoofd/aanduiding van de zorgorgaanbieder en zorgverlener en identificatie informatie van de patiënt , zonder diens BSN.

### Referentiesets worden opgenomen in de templates zodra deze opgeleverd zijn voor integratie ###
Als paramedicus wil ik in het behandelplan, zodra dit gereed is, de referentieset voor verrichtingen kunnen gebruiken bij verrichtingen. De wijze waarop vraagt nog uitwerking.

# Paramedie specifieke eisen ten voor het beschikbaar stellen van 'Correspondentie en berichten' via het PGO
Voor correspondentie en berichten die niet zijn gebaseerd op een GUPZ document template geldt dat:

- Deze handmatig mogen worden ingevoerd en aangepast
- Deze (deels) op dossiervelden gebaseerd mogen zijn, maar dat hoeft niet. De op de dossiervelden gebaseerde inhoud van een document mag handmatig worden aangepast
- Het document niet automatisch moet woet worden aanpast/ gearchiveerd bij wijziging van onderliggende dossiervelden
- De statusvoering gelijk is aan de statusvoering voor dossiersamenvattingen
  
