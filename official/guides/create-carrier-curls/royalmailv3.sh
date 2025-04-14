curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "RoyalMailV3Account",
    "description": "RoyalMailV3Account",
    "credentials": {
      "account_number": "VALUE",
      "contact_name": "VALUE",
      "contact_phone": "VALUE",
      "dispatch_city": "VALUE",
      "dispatch_country": "VALUE",
      "dispatch_state": "VALUE",
      "dispatch_street1": "VALUE",
      "dispatch_street2": "VALUE",
      "dispatch_zip": "VALUE",
      "internal_location_id": "VALUE",
      "oba_access_code": "VALUE",
      "oba_email_address": "VALUE",
      "posting_location_number": "VALUE"
    }
  }
}'
