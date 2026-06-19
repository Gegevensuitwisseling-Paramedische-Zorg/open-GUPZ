---
title: Verwijzen
layout: template
filename: referral.md
--- 

# Verwijzen #

## FHIR Implementation Guide ##
Het dataplatform volgt de door ZorgDomein opgestelde  [General FHIR specifications](https://integrator.zorgdomein.com/fhir-specs/). 


### Vecozo dienst Verwijzen ###
De Vecozo dienst 'Verwijzen' volgt de door ZorgDomein opgestelde [General FHIR specifications](https://integrator.zorgdomein.com/fhir-specs/) met een aantal kleine verschillen.

**ZD ReferralRequest**   
Binnen de ZorgDomein specificaties is het system van de identifier een fixed value (http://zorgdomein.nl/zdnumber/). Vecozo gebruikt daarentegen urn:nl:verwijzen:verwijsnummer.

**ZD Organization**   
Vecozo gebruikt altijd het AGB nummer van de organisatie als identifier. Binnen ZorgDomein worden soms ook andere identifiers gebruikt

**Dossiergegevens**   
Vecozo stuurt geen (semi-)gestructureerde (narrative) dossiergegevens mee zoals ZorgDomein dat doet. Note: ZorgDomein stuurt dossiergegevens voor zover deze door de bronsystemen beschikbaar zijn gesteld. Dossiergegevens worden wel in de verwijsbrief zelf opgenomen.

**Document types**   
De ZorgDomein FHIR specificatie gaat uit van het [uitwisselen (PUSH) van clinical documents](https://integrator.zorgdomein.com/fhir-specs/fhir-documents/). Patient informatie wordt gebundeld in een document dat voldoet aan het [ZD Document](https://integrator.zorgdomein.com/fhir-specs/resource-profiles/zd-document/) profile. Ieder document kent een type waarin waarden uit de [Document type](https://integrator.zorgdomein.com/terminology/code-system/document-type/) codesystem mogen worden opgenomen. 

Vecozo ondersteunt een subset van de ZorgDomein document typee. Onderstaande tabel bevat de door Vecozo ondersteunde subtypes (en bijbehorende transacties).


| Code                 | Display value       | 
| -------------------- | ------------------- | 
| referral-letter      | Verwijsbrief        |
| supplement           | Nazending           |
| cancellation         | Annuleringsbericht  |


## Security ##
De implementatie zoals beschreven in [Security](security.md) wordt gevolgd. Verschillende aanbieders van verwijsdiensten kennen aanvullende implementatie.

### Vecozo dienst Verwijzen ###

**Aanvullingen ten aanzien van transport level security**
- Vecozo kan gebruik maken van een door Vecozo zelf uitgegeven sleutel/ certificaat (klanten maken vaak al gebruik van certificaten die zijn uitgegeven door VECOZO voor andere diensten)
- Vecozo vereist geen PKIO certificaat van het Zorgplatform, ieder door een CA uitgegeven certificaat volstaat

**Aanvullingen ten aanzien van application level security**
- JWT tokens bevatten geen patient en zorgaanbieder fields. 
- JWT tokens worden alleen gesigned en niet encrypted. Dit is ook mogelijk omdat de tokens geen BSN bevatten
- De waarde van het field iss in het JWT token is altijd  'urn:nl:verwijzen:webportaal'

### ZorgDomein ###
De specifieke eisen worden beschreven in [ZorgDomein Integrator](https://integrator.zorgdomein.com/fhir-specs/security/).
