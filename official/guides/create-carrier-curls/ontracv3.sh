curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "type": "OntracV3Account",
  "description": "OntracV3Account",
  "carrier_account": {
    "credentials": {
      "api_id": "VALUE",
      "api_key": "VALUE",
      "facility": "VALUE",
      "injection_city": "VALUE",
      "injection_contact": "VALUE",
      "injection_country": "VALUE",
      "injection_instruction": "VALUE",
      "injection_phone": "VALUE",
      "injection_state": "VALUE",
      "injection_street1": "VALUE",
      "injection_street2": "VALUE",
      "injection_zip": "VALUE"
    }
  }
}'
