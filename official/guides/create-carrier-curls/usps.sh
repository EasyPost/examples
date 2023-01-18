curl -X POST https://api.easypost.com/v2/carrier_accounts \
-u "$EASYPOST_API_KEY": \
-H 'Content-Type: application/json' \
-d '{
  "type": "UspsAccount",
  "description": "UspsAccount",
  "carrier_account": {
    "credentials": {
      "address_city": "VALUE",
      "address_state": "VALUE",
      "address_street": "VALUE",
      "address_zip": "VALUE",
      "company_name": "VALUE",
      "email": "VALUE",
      "phone": "VALUE",
      "shipper_id": "VALUE"
    }
  }
}'
