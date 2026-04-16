---
title: Platform specifieke eisen voor de MedMij Documenten dienst (PDF/A)
layout: template
filename: Medmij-pdfa.md
--- 

# Paramedie specifieke eisen aan het beschikbaarstellen van documenten via het PGO #

## Functionele eisen en wensen voor het beschikbaar stellen van documenten aan het PGO ##
Het genereren en PGO  uitwisseling van de templatre behandelplan is als voorbeeld uitgewerkt, onderstaande functionele wensen gelden echter voor alle documenten voor PGO uitwisseling, dus ook voor paramedische diagnose en brieven/updates bijv. Functionele wensen raken potentieel zowel de werking van het PARIS als van het dataplatform.
 
### Het template is beschikbaar in het PARIS ###
De  paramedicus kan alleen bovenstaande zaken opstellen via het daarvoor gemaakte template. Dat vormt de minimale basis. Het template is een output norm.
Als er een PDFA genereert wordt en sjabloonveld zijn niet gevuld, dan wordt dit veld niet opgenomen in de PDFA die genereert wordt voor de uitwisseling, zodat er geen lege velden in de PDFA staan.  

NVLF subdoelen: Als paramedicus wil ik dat de velden van het behandelplan in het PGO waar mijn beroepsgroep geen gebruik van maakt niet getoond worden in het PGO. Dit geldt voor het onderdeel Subdoelen voor de NVLF.
Optometrie: als ik als paramedicus een diagnostiekplan opstel wil ik gebruik kunnen maken van landelijke protocollen, zodat ik snel een standaard diagnostiekplan heb.

### Alleen definitieve documenten worden met PGO gedeeld ###
De paramedicus markeert actief een document als definitief, waarmee deze aangeeft dat dit document gereed is, in het dossier als versie bewaard moet worden en klaar is voor  uitwisseling naar het PGO.
Dit geldt voor alle opgestelde templates die als PDF/A uitgewisseld worden.

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
