# LocalXPose tunnel voor testdoeleinden oppzetten

## Inleiding
Om te kunnen testen met Interoplab of een externe toepassing zoals een MedMij DVA, moet de lokale ontwikkelserver/ testserver bereikbaar zijn via een publieke URL. 
Aanvullende maatregelen zijn nodig om een veilige verbinding tot stand te brengen. Binnen openGUPZ is ervoor gekozen om, omwille van beheersbaarheid en veiligheid, geen gebruik te maken van VPN connecties maar van een tunneling service.
In principe kan iedere tunneling service worden gebruikt mits deze geen TLS terminatie doet, omdat het openGUPZ beveiligingsmodel vereist dat het PARIS clientcertificaten van de aanroepende partij controleert.

## Gebruik van LocalXPose
Vanuit het GUPZ programma wordt LocalXPose als tunneling service vergoed voor de deelnemende PARIS leveranciers. Opzetten van een tunnel kan met behulp van het onderstaande script.

```
@echo off
set ACCESS_TOKEN=[ACCESS TOKEN WORDT OP VERZOEK VERSTREKT]
loclx tunnel tls --to [ADRES EN POORT LOKALE SERVICE] --reserved-domain [DOMEIN WORDT OP VERZOEK VERSTREKT]
pause
```

## Aanvragen van een ACCESS TOKEN en domeinnaam
PARIS leveranciers die deelnemen aan de eerste en de tweede ring kunnen een access token en dommeinnaam (met bijbehorende testcertificaten) aanvragen. 
Contactinformatie volgt.
