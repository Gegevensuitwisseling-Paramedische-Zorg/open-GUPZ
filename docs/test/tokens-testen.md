# Authenticatie tokens testen 

## Een authenticatietoken genereren 
Gebruik de jwtcli commandline tool om een JWE authentcatietoken te genereren met opgegeven inhoud. De JWE is gesigned en encrypted zoals beschreven in [security.md](/docs/api/security.md) 
De inhoud van dit token kan in interoplab aan de authorize header worden toegevoegd.

## Een authenticatietoken valideren
Gebruik de jwtdcli commandline tool om een JWE te decrypten. De resulterende 'raw' jws kan worden gevalideerd in jwt.io
