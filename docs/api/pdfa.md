---
title: PDF/A
layout: template
filename: pdfa.md
--- 

# PDF/A documenten #

## Ongestructureerde documenten beschikbaar stellen in PDF/A formaat ##
Het dataplatform beschikt over een FHIR API om ongestructureerde documenten beschikbaar te stellen in PDF/A formaat. Het koppelvlak kan worden gebruikt ongeacht een specifieke use case, voor zowel het beschikbaar stellen van documenten aan patiënten (MedMij PGO of anderzins) als zorgverleners (in het kader van bijvoorbeeld terugrapportage of netwerkzorg).

Binnen openGUPZ wordt onderscheid gemaakt in twee verschillende typen documenten:

### Dossiersamenvattingen ###
Dit betreft een statische weergave van (een deel van) het dossier op een gegeven moment in de tijd, ook wel een snapshot van het dossier genoemd. Dossiersamenvattingen worden door het PARIS gegenereerd uit de beschikbare dossierinformatie. De gegenereerde tekst kan **niet** door de eindgebruiker worden aangepast of aangevuld. Alleen de brongegevens (het dossier) kunnen worden aangepast, waarna een nieuw document kan worden gegenereerd, of een nieuwe versie van het document kan worden gegenereerd.

### Correspondentie en berichten ###
Dit betreft documenten die (deels) kunnen worden gegenereerd uit beschikbare dossierinformatie, maar waarvan de gegenereerde tekst door de eindgebruiker kan worden aangepast dan wel aangevuld. 

### Specifieke functionele eisen in het kader van MedMij ###
Specifieke functionele eisen ten aanzien van het beschikbaar stellen van documenten aan een MedMij PGO worden gegeven in [Medmij-pdfa](/docs/requirements/Medmij-pdfa.md)

## FHIR Implementation Guide ##
Het dataplatform volgt de door Nictiz opgestelde  [MedMij FHIR Implementation Guide: PDF/A 3.0.53](https://informatiestandaarden.nictiz.nl/wiki/MedMij:V2020.01/FHIR_PDFA). Alleen de use case 'Find and retrieve existing PDF/A document(s)' wordt ondersteund. De MHD transactie 'Find Document Manifest' wordt niet ondersteund. Het dataplatform vervult de rol van 'document responder'. 

| System | MHD Actor | Transaction | Optionallity |
| ------ | --------- | ----------- | ------------ |
| DVA    | Document Consumer | Find Document Reference | Required |
| DVA    | Document Consumer | Retrieve Document | Required |
| Dataplatform | Document Responder | Find Document Reference | Required |
| Dataplatform | Document Responder | Retreive Document | Required |

### Document referenties ###
Het dataplatform biedt alle documentreferenties aan als verwijzing naar een binary resource. Dit betekent dat de Retrieve Document transactie de binary resource bevraagt.

### Document status ###
Beschikbaar gestelde documenten krijgen een status:

| FHIR status | Nictiz status | GUPZ status | EPD status | 
| ------ | --------- | ----------- | ------ |
| current| approved |Actueel | Keuze PARIS |
| superseded | depricated | Gearchiveerd | Keuze PARIS |
| entered-in-error| entered-in-error | Foutief | Keuze PARIS |
| unkown| unkown | Onbekend |Keuze PARIS |
| - | - | Concept | Keuze PARIS |

In de MedMij kwalificatie wordt uitgegaan van de door Nictiz gehanteerde statussen. Om die reden gebruikt het dataplatform de Nictiz coderingen voor het **DocumentReference.status** veld. Waar Nictiz geen waarde aangeeft wordt uitgegaan van de Standaard HL7 FHIR statussen.

> [!IMPORTANT]
> Documenten met de openGUPZ status 'Concept' worden nooit via de PDF/A API beschikbaar gesteld.

> [!IMPORTANT]
> Voor dossiersamenvattingen geldt dat als het onderliggende dossier wordt aangepast, documenten met de openGUPZ status 'Concept' die op dezelfde dossiervelden zijn gebaseerd, automatisch worden bijgewerkt

> [!IMPORTANT]
> Voor dossiersamenvattingen geldt dat als het onderliggende dossier wordt aangepast, documenten met de openGUPZ status 'Actueel' die op dezelfde dossiervelden zijn gebaseerd, de status openGUPZ status 'Gearchiveerd' krijgen, zodra het nieuwe document de status 'Actueel' krijgt
> Het nieuwe 'Actuele' document **mag** verwijzen naar de gearchiveerde versie via het DocumentReference.relatesTo veld. In dat geval wordt de HL7 FHIR codering 'replaces ' gebruikt.

> [!NOTE]
> Indien een document te status 'entered-in-error' krijgt, **en** er kan met zekerheid worden vastgesteld dat het document door geen enkele (externe) gebruiker is ingezien, dan mag het document worden verwijderd.


## Security ##
De beveiliging van verkeer tussen client en het dataplatform wordt beschreven in [security.md](security.md).
