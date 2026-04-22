---
title: Verwijzen
layout: template
filename: referral.md
--- 

# Verwijzen #

## FHIR Implementation Guide ##
Het dataplatform volgt de door ZorgDomein opgestelde  [General FHIR specifications](https://integrator.zorgdomein.com/fhir-specs/). 

> [!IMPORTANT]
> Verder uitwerken wat exact wordt ontvangen en wat wordt verstuurd.

> [!IMPORTANT]
> Verschillen tussen Vecozo en ZorgDomein beschrijven

## Security ##
De implementatie zoals beschreven in [](security.md) wordt gevolgd. Verschillende aanbieders van verwijsdiensten kennen aanvullende implementatie.

### Vecozo ###

**Aanvullingen ten aanzien van transport level security**
- Vecozo kan gebruik maken van een door Vecozo zelf uitgegeven sleutel/ certificaat (klanten maken vaak al gebruik van certificaten die zijn uitgegeven door VECOZO voor andere diensten)
- Vecozo vereist geen PKIO certificaat van het Zorgplatform, ieder door een CA uitgegeven certificaat volstaat

**Aanvullingen ten aanzien van application level security***
- JWT tokens bevatten geen patient en zorgaanbieder fields. 
- JWT tokens worden alleen gesigned en niet encrypted. Dit is ook mogelijk omdat de tokens geen BSN bevatten
- De waarde van het field iss in het JWT token is altijd  'urn:nl:verwijzen:webportaal'

### ZorgDomein ###
De specifieke eisen worden beschreven in [Security](https://integrator.zorgdomein.com/fhir-specs/security/).
