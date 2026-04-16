
# PDF/A #

## FHIR Implementation Guide ##
Het dataplatform volgt de door Nictiz opgestelde  [MedMij FHIR Implementation Guide: PDF/A 3.0.53](https://informatiestandaarden.nictiz.nl/wiki/MedMij:V2020.01/FHIR_PDFA). Alleen de use case 'Find and retrieve existing PDF/A document(s)' wordt ondersteund. De MHD transactie 'Find Document Manifest' wordt niet ondersteund. Het dataplatform vervult de rol van 'document responder'. 

| System | MHD Actor | Transaction | Optionallity |
| ------ | --------- | ----------- | ------------ |
| DVA    | Document Consumer | Find Document Reference | Required |
| DVA    | Document Consumer | Retrieve Document | Required |
| Dataplatform | Document Responder | Find Document Reference | Required |
| Dataplatform | Document Responder | Retreive Document | Required |

## Security ##
De beveiliging van verkeer tussen Dienstverlener Aanvieder (DVA) en het dataplatform wordt beschreven in [security.md](security.md).
