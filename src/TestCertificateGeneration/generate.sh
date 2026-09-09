#!/bin/bash
set -e
export MSYS_NO_PATHCONV=1

# Configuratie
PARIS_FILE="paris.txt"
DVA_FILE="dva.txt"
CA_DIR="ca"
OUT_DIR="output"
PARIS_OUT_DIR="$OUT_DIR/paris"

# Vraag de gebruiker om een wachtwoord (onzichtbaar tijdens typen)
read -s -p "Voer het wachtwoord in voor de PFX bestanden: " PFX_PASS
echo "" # Voeg een nieuwe regel toe na de verborgen invoer

# Controleer of configuratiebestanden bestaan
if [ ! -f "$PARIS_FILE" ] || [ ! -f "$DVA_FILE" ]; then
    echo "Fout: Zorg ervoor dat $PARIS_FILE en $DVA_FILE bestaan in deze map."
    exit 1
fi

# 1. Voorbereiding & Opschonen
mkdir -p "$CA_DIR"

if [ -d "$OUT_DIR" ]; then
    rm -rf "${OUT_DIR:?}/"*
else
    mkdir -p "$OUT_DIR"
fi

mkdir -p "$PARIS_OUT_DIR"

# 2. Root CA genereren of hergebruiken
if [ -f "$CA_DIR/rootCA.key" ] && [ -f "$CA_DIR/rootCA.crt" ]; then
    echo "Bestaand Root CA certificaat gevonden. Deze wordt hergebruikt."
else
    echo "Geen Root CA gevonden. Nieuwe Root CA genereren..."
    openssl req -x509 -newkey rsa:4096 -days 3650 -nodes -keyout "$CA_DIR/rootCA.key" -out "$CA_DIR/rootCA.crt" -subj "/CN=GUPZ Test Root CA"
fi

# 3. Server SSL certificaten genereren
echo "Server SSL certificaten genereren vanuit $PARIS_FILE..."
while IFS= read -r domain || [ -n "$domain" ]; do
    domain="${domain%$'\r'}"
    [ -z "$domain" ] && continue
    
    echo " - Genereren voor: $domain"
    DOMAIN_DIR="$PARIS_OUT_DIR/$domain"
    mkdir -p "$DOMAIN_DIR"
    
    echo "subjectAltName=DNS:$domain" > "$DOMAIN_DIR/${domain}_ext.cnf"
    
    openssl req -newkey rsa:2048 -nodes -keyout "$DOMAIN_DIR/${domain}.key" -out "$DOMAIN_DIR/${domain}.csr" -subj "/CN=$domain"
    openssl x509 -req -in "$DOMAIN_DIR/${domain}.csr" -CA "$CA_DIR/rootCA.crt" -CAkey "$CA_DIR/rootCA.key" -CAcreateserial -out "$DOMAIN_DIR/${domain}.crt" -days 365 -extfile "$DOMAIN_DIR/${domain}_ext.cnf"
    
    # Exporteer direct naar PFX
    openssl pkcs12 -export -legacy -out "$DOMAIN_DIR/${domain}.pfx" -inkey "$DOMAIN_DIR/${domain}.key" -in "$DOMAIN_DIR/${domain}.crt" -certfile "$CA_DIR/rootCA.crt" -passout pass:$PFX_PASS
    
    # Bereken de SHA1 Thumbprint, forceer kleine letters en sla op in de specifieke domeinmap
    tp=$(openssl x509 -in "$DOMAIN_DIR/${domain}.crt" -noout -fingerprint -sha1 | cut -d'=' -f2 | tr -d ':' | tr '[:upper:]' '[:lower:]')
    echo "$tp" > "$DOMAIN_DIR/thumbprint.txt"
    
    cp "$CA_DIR/rootCA.crt" "$DOMAIN_DIR/"
    rm -f "$DOMAIN_DIR"/*.csr "$DOMAIN_DIR"/*.cnf
done < "$PARIS_FILE"

# 4. mTLS Client certificaten genereren
echo "mTLS Client certificaten genereren vanuit $DVA_FILE..."
while IFS= read -r client || [ -n "$client" ]; do
    client="${client%$'\r'}"
    [ -z "$client" ] && continue

    echo " - Genereren voor: $client"
    filename=$(echo "$client" | tr '[:upper:]' '[:lower:]')
    DVA_DIR="$OUT_DIR/dva/$filename"
    mkdir -p "$DVA_DIR"
    
    echo "extendedKeyUsage=clientAuth" > "$DVA_DIR/client_ext.cnf"
    
    openssl req -newkey rsa:2048 -nodes -keyout "$DVA_DIR/${filename}_client.key" -out "$DVA_DIR/${filename}_client.csr" -subj "/CN=$client"
    openssl x509 -req -in "$DVA_DIR/${filename}_client.csr" -CA "$CA_DIR/rootCA.crt" -CAkey "$CA_DIR/rootCA.key" -CAcreateserial -out "$DVA_DIR/${filename}_client.crt" -days 365 -extfile "$DVA_DIR/client_ext.cnf"
    
    # Forceer ook hier -legacy voor Windows compatibiliteit
    openssl pkcs12 -export -legacy -out "$DVA_DIR/${filename}_client.pfx" -inkey "$DVA_DIR/${filename}_client.key" -in "$DVA_DIR/${filename}_client.crt" -certfile "$CA_DIR/rootCA.crt" -passout pass:$PFX_PASS
    
    cp "$CA_DIR/rootCA.crt" "$DVA_DIR/"
    rm -f "$DVA_DIR"/*.csr "$DVA_DIR"/*.cnf
done < "$DVA_FILE"

# 5. Opschonen tijdelijke bestanden
rm -f "$CA_DIR"/rootCA.srl

echo "Klaar! Elk servermapje bevat nu een 'thumbprint.txt' met de hash in kleine letters."