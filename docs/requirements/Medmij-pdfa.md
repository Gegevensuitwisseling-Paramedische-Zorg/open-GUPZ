---
title: Platform specifieke eisen voor de MedMij Documenten dienst (PDF/A)
layout: template
filename: Medmij-pdfa.md
--- 

# Paramedie specifieke eisen aan het beschikbaarstellen van documenten via het PGO #

## Functionele eisen en wensen voor het beschikbaar stellen van documenten aan het PGO ##
Het genereren en beschikbaar stellen aan het PGO van een behandelplan is als voorbeeld uitgewerkt, onderstaande functionele wensen eisen gelden echter voor alle documenten die aan het PGO beschikbaar worden gesteld, dus ook voor paramedische diagnose en brieven/updates bijv. Functionele wensen raken potentieel zowel de werking van het PARIS als van het dataplatform.
 
### Vastlegging in het PARIS voldoet aan de door de beroepsgroepen vastgestelde document-templates ###
Alle velden die zijn opgenomen in de document-templates kunnen in het PARIS door de paramedicus worden vastgelegd. 
De  paramedicus kan alleen bovenstaande zaken opstellen via het daarvoor gemaakte template. Het template vormt de minimale basis voor registratie en is de norm voor output (naar brieven en documenten). Dit wil zeggen dat gegenereerde documenten geen velden bevatten die niet in het template zijn gedefinieerd.  

Als er een PDF/A genereert wordt en sjabloonveld zijn niet gevuld, dan wordt dit veld niet opgenomen in de PDF/A die genereert wordt voor de uitwisseling, zodat er geen lege velden in de PDFA staan.  

<ins>NVLF specifiek:</ins>  
Leden van de NVLF leggen geen subdoelen vast. Deze worden dus ook niet in de betreffende PARISen aangeboden en ook niet in de gegenereerde PDF/A opgenomen.
<ins>Optometrie:</ins>  
als ik als paramedicus een diagnostiekplan opstel wil ik gebruik kunnen maken van landelijke protocollen, zodat ik snel een standaard diagnostiekplan heb.

### Voor alle aan het PGO aangeboden documenten wordt een status bijgehouden ###
Behandelplannen en de overige aan het PGO aangeboden documenten hebben een status. De status van documenten is in het PARIS in te zien. Het betreft de volgende statussen:

- Concept:
  Dit is een behandelplan (document) dat door paramedicus gemaakt of gegenereert is (bijvoorbeeld op basis van een bestaand behandelplan), maar dat nog niet als definitief is gemarkeerd.  Naast de status wordt ook de datum vastgelegd waarop het behandelplan (het document) gemaakt is.
- Actueel:  
Dit is de actuele versie van het behandelplan, dat de basis vormt voor de behandeling. Deze status wordt bij het behandelplan (het document) vastgelegd zodra de paramedicus het document als 'definitief' markeert. Naast de status wordt ook de datum vastgelegd waarop het behandelplan (het document) als definitief werd gemarkeerd en wordt een eventuele geldigheidsduur vastgelegd

- Gearchiveerd:  
  Dit is een behandelplan (document) dat definitief was, maar wordt vervangen door een nieuwe versie van het behandelplan. Wanneer een concept behandelplan (document) definitief wordt gemaakt, wordt een eventuele bestaande als definitief gemarkeerde versie gearchiveerd. Naast de status wordt ook de archiefdatum vastgelegd.

### Alleen definitieve documenten worden met PGO gedeeld ###
De paramedicus markeert actief een document als definitief, waarmee deze aangeeft dat dit document gereed is, in het dossier als versie bewaard moet worden en klaar is voor  uitwisseling naar het PGO. Alleen als definitiefg gemarkeerde behandelplannen (documenten) mogen met het PGO worden gedeeld. Dit geldt voor alle documenten die als PDF/A uitgewisseld worden.

### Een wijziging in een eerder gemaakt document leidt altijd tot een nieuwe versie van dat document ###
De paramedicus kan een bestaand behandelplan wijzigen, definitief maken en bewaren als nieuwe versie. De oude versie wordt daarmee automatisch gearchiveerd.
De paramedicus kan bij het maken van een nieuwe versie van een behandelplan kiezen voor een blanco format of voor een kopie van het vorige behandelplan. In dat laatste geval wordt de informatie van het vorige behandelplan overgenomen waarna de paramedicus dit kan opslaan.
Als het behandelplan  klaar is, maakt de paramedicus dit actief definitief, waarna het behandelplan bewaard wordt als herkenbare nieuwe, actuele versie. De vorige versie van het behandelplan is daarmee automatisch niet meer actueel, en wordt gearchiveerd. Dit blijft wel bewaard in het dossier.

### De behandelaar kan zien wat de actuele versie is van het behandelplan ###
Omdat er over tijd meerdere behandelplannen kunnen zijn, heeft een behandelplan een status. Een behandelplan kan de volgende status hebben:  
- Actueel:  
Dit is het laatste definitief gemaakt behandelplan, dat de basis vormt voor de behandeling. Dit behandelplan bevat de datum dat dit definitief gemaakt is en de geldigheidsduur.
- Concept:
  Dit is een behandelplan dat de paramedicus nieuw gestart is, of als kopie gemaakt heeft van een bestaand behandelplan maar dat niet actief definitief gemaakt is. Dit behandelplan bevat de datum dat het aangemaakt is, geen verdere data.
- Gearchiveerd:  
  Dit is een (voorheen) actueel behandelplan dat vervangen is door een nieuw behandelplan. Een actueel behandelplan wordt pas gearchiveerd als de behandelaar een nieuw concept behandelplan definitief maakt. Dit behandelplan bevat datum aangemaakt, datum gearchiveerd.

### De paramedicus kan per cliënt een overzicht zien van alle behandelplannen ###
De paramedicus heeft van iedere cliënt een overzicht van alle behandelplannen, inclusief status zodat hij zelf de historie heeft.
Nieuwe versies van een behandelplan worden na definitief maken automatisch beschikbaar voor het PGO.
Als er voor de patiënt  een nieuw behandelplan opgesteld is, heeft de paramedicus dit besproken met de patiënt . De patiënt  kan vervolgens in het PGO het nieuwe behandelplan ophalen. Het oude behandelplan blijft ook beschikbaar in het PGO. Voor de patiënt  is duidelijk welke plan actueel is, en welke plannen geactiveerd zijn. De patiënt ziet van de plannen de start- en evt einddatum en de status.

### Alleen documenten die de paramedicus zelf heeft gegenereerd worden naar PGO uitgewisseld ###
Alleen behandelplannen die de paramedicus zelf schrijft en definitief maakt zijn beschikbaar voor uitwisseling naar PGO. PDF/A die de paramedicus van derden ontvangen heeft, denk aan de verwijsbrief bijv. worden niet via het PARIS beschikbaar gesteld voor PGO. De patiënt  kan dit opvragen via het PGO en de zorgaanbieder die dit opgesteld heeft.

### Niet ingevulde verlden worden niet opgenomen in de gegenereerde PDF/A ###
Als er een PDFA gegeneerd wordt en een sjabloonveld is niet ginevuld, dan wordt dit veld niet opgenomen in de PDFA die gegeneerd wordt voor de uitwisseling, zodat er geen lege velden in de PDFA staan.

### Een client kan meerdere actuele behandelplannen hebben indien deze in behandeling is voor verschillende diagnoses ###
Als paramedicus wil ik meerdere parallelle actuele behandelplannen in het PARIS kunnen hebben, gekoppeld aan verschillende diagnoses, als een patient voor meerdere diagnoses in behandeling is.

### Ieder document bevat een briefhoofd met identificatie van de auteur en de patiënt ###
Alle PDF/A documenten bevatten een briefhoofd/aanduiding van de zorgorgaanbieder en zorgverlener en identificatie informatie van de patiënt , zonder diens BSN.

### Referentiesets worden opgenomen in de templates zodra deze opgeleverd zijn voor integratie ###
Als paramedicus wil ik in het behandelplan, zodra dit gereed is, de referentieset voor verrichtingen kunnen gebruiken bij verrichtingen. De wijze waarop vraagt nog uitwerking.
