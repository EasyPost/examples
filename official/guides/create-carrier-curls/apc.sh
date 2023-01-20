curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "type": "ApcAccount",
  "description": "ApcAccount",
  "carrier_account": {
    "credentials": {
      "facility": "VALUE",
      "password": "VALUE",
      "shipper_id": "VALUE"
    }
  }
}'
