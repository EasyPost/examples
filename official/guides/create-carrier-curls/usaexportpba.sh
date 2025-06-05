curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "UsaExportPbaAccount",
    "description": "UsaExportPbaAccount",
    "credentials": {
      "address_city": "VALUE",
      "address_state": "VALUE",
      "address_street": "VALUE",
      "address_street2": "VALUE",
      "address_zip": "VALUE",
      "company_name": "VALUE",
      "country": "VALUE",
      "email": "VALUE",
      "name": "VALUE",
      "phone": "VALUE"
    }
  }
}'
