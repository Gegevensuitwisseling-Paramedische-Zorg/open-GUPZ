---
title: Platform specifieke eisen voor de MedMij Documenten dienst (PDF/A)
layout: template
filename: Medmij-pdfa.md
--- 

# Paramedie specifieke eisen aan het beschikbaarstellen van documenten via het PGO #

## Functionele eisen en wensen voor het beschikbaar stellen van documenten aan het PGO ##
Het genereren en beschikbaar stellen aan het PGO van een behandelplan is als voorbeeld uitgewerkt, onderstaande functionele eisen gelden echter voor alle documenten die aan het PGO beschikbaar worden gesteld, dus ook voor paramedische diagnose en brieven/updates bijv. Functionele eisen raken potentieel zowel de werking van het PARIS als van het dataplatform.
 
### Vastlegging in het PARIS voldoet aan de door de beroepsgroepen vastgestelde document-templates ###
Alle velden die zijn opgenomen in de document-templates kunnen in het PARIS door de paramedicus worden vastgelegd. 
De  paramedicus kan alleen bovenstaande zaken opstellen via het daarvoor gemaakte template. Het template vormt de minimale basis voor registratie en is de norm voor output (naar brieven en documenten). Dit wil zeggen dat gegenereerde documenten geen velden bevatten die niet in het template zijn gedefinieerd.  

Als er een PDF/A genereert wordt en sjabloonveld zijn niet gevuld, dan wordt dit veld niet opgenomen in de PDF/A die genereert wordt voor de uitwisseling, zodat er geen lege velden in de PDFA staan.  

<ins>NVLF specifiek:</ins>  
Leden van de NVLF leggen geen subdoelen vast. Deze worden dus ook niet in de betreffende PARISen aangeboden en ook niet in de gegenereerde PDF/A opgenomen. 

### Specifieke eisen voor de optometrie ten aanzien van het template Diagnostiekplan ###
> [!IMPORTANT]
> Voor de optometrie geldt dat diagnostiekplan zoveel mogelijk moet worden opgesteld op basis van landelijke protocollen. Specifieke eisen volgen nog.

### Voor alle gegenereerde documenten wordt een status bijgehouden ###
Behandelplannen en de overige documenten hebben een status. De status van documenten is in het PARIS in te zien. Het betreft de volgende statussen:

- Concept:
  Dit is een behandelplan (document) dat door paramedicus gemaakt of gegenereert is (bijvoorbeeld op basis van een bestaand behandelplan), maar dat nog niet als definitief is gemarkeerd.  Naast de status wordt ook de datum vastgelegd waarop het behandelplan (het document) gemaakt is.
- Actueel:  
Dit is de actuele versie van het behandelplan, dat de basis vormt voor de behandeling. Deze status wordt bij het behandelplan (het document) vastgelegd zodra de paramedicus het document als 'definitief' markeert. Naast de status wordt ook de datum vastgelegd waarop het behandelplan (het document) als definitief werd gemarkeerd en wordt een eventuele geldigheidsduur vastgelegd  
- Gearchiveerd:  
  Dit is een behandelplan (document) dat definitief was, maar wordt vervangen door een nieuwe versie van het behandelplan. Wanneer een concept behandelplan (document) definitief wordt gemaakt, wordt een eventuele bestaande als definitief gemarkeerde versie gearchiveerd. Naast de status wordt ook de archiefdatum vastgelegd.

### Alleen documenten met de status 'Actueel' worden aan het PGO beschikbaargesteld ###
De paramedicus markeert actief een document als definitief, waarmee deze aangeeft dat dit document gereed is, in het dossier als versie bewaard moet worden en klaar is voor  uitwisseling naar het PGO. Alleen als definitief gemarkeerde behandelplannen (documenten) mogen met het PGO worden gedeeld. Een als definitief gemarkeerd behandelplan (document) krijgt de status 'actueel' en komt automatisch, zonder dat daar verdere gebruikersinteractie voor benodigd is, beschikbaar aan het PGO.  Dit geldt voor alle documenten die als PDF/A uitgewisseld worden.

### Een wijziging in een eerder gemaakt document leidt altijd tot een nieuwe versie van dat document ###
De paramedicus kan een bestaand behandelplan wijzigen, definitief markeren en bewaren als nieuwe versie waardoor ze de status 'actueel' krijgt. De oude versie wordt daarmee automatisch gearchiveerd en krijgt de status 'gearchiveerd'.

De paramedicus kan bij het maken van een nieuwe versie van een behandelplan kiezen voor een blanco format of voor een kopie van het vorige behandelplan. In dat laatste geval wordt de informatie van het vorige behandelplan overgenomen waarna de paramedicus dit kan opslaan. Zolang de nieuwe versie niet als 'definitief' gemarkeerd wordt, houdt ze de status 'concept'.

Als het behandelplan  klaar is, markeert de paramedicus haar als definitief, waarna het behandelplan bewaard wordt als herkenbare nieuwe, actuele versie met de status 'actueel'. De vorige versie van het behandelplan is daarmee automatisch niet meer actueel, en wordt gearchiveerd (status gearchiveerd). Dit blijft wel bewaard in het dossier.

### De behandelaar kan de versiehistorie van een document inzien ###
Standaard ziet de behandelaar de actuele versie (status Actueel) van documenten. Het Paris biedt echter de mogelijkheid om andere versies van documenten (met de status Concept of Archief) in te zien.

### Alleen documenten die de paramedicus zelf heeft gegenereerd worden aan het PGO beschikbaargesteld ###
Alleen behandelplannen die de paramedicus zelf schrijft en definitief maakt zijn beschikbaar voor uitwisseling naar PGO. PDF/A die de paramedicus van derden ontvangen heeft, denk aan de verwijsbrief bijv. worden niet via het PARIS beschikbaar gesteld voor PGO. De patiënt  kan dit opvragen via het PGO en de zorgaanbieder die dit opgesteld heeft.

### Niet ingevulde verlden worden niet opgenomen in de gegenereerde PDF/A ###
Als er een PDFA gegeneerd wordt en een sjabloonveld is niet ginevuld, dan wordt dit veld niet opgenomen in de PDFA die gegeneerd wordt voor de uitwisseling, zodat er geen lege velden in de PDFA staan.

### Een client kan meerdere actuele behandelplannen hebben indien deze in behandeling is voor verschillende diagnoses ###
Als paramedicus wil ik meerdere parallelle actuele behandelplannen in het PARIS kunnen hebben, gekoppeld aan verschillende diagnoses, als een patient voor meerdere diagnoses in behandeling is.

### Ieder document bevat een briefhoofd met identificatie van de auteur en de patiënt ###
Alle PDF/A documenten bevatten een briefhoofd/aanduiding van de zorgorgaanbieder en zorgverlener en identificatie informatie van de patiënt , zonder diens BSN.

### Referentiesets worden opgenomen in de templates zodra deze opgeleverd zijn voor integratie ###
Als paramedicus wil ik in het behandelplan, zodra dit gereed is, de referentieset voor verrichtingen kunnen gebruiken bij verrichtingen. De wijze waarop vraagt nog uitwerking.
