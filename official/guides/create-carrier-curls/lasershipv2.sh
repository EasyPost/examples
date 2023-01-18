curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "type": "LasershipV2Account",
  "description": "LasershipV2Account",
  "carrier_account": {
    "credentials": {
      "api_id": "VALUE",
      "api_key": "VALUE",
      "cargo_claim_value": "VALUE",
      "facility": "VALUE",
      "injection_city": "VALUE",
      "injection_contact": "VALUE",
      "injection_country": "VALUE",
      "injection_email": "VALUE",
      "injection_instruction": "VALUE",
      "injection_location_type": "VALUE",
      "injection_note": "VALUE",
      "injection_organization": "VALUE",
      "injection_phone": "VALUE",
      "injection_phone_ext": "VALUE",
      "injection_state": "VALUE",
      "injection_street1": "VALUE",
      "injection_street2": "VALUE",
      "injection_zip": "VALUE",
      "is_reseller": "VALUE"
    }
  }
}'
