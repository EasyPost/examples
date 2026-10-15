curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "PurolatorAccount",
    "description": "PurolatorAccount",
    "credentials": {
      "account_number": "VALUE",
      "api_key": "VALUE",
      "password": "VALUE"
    }
  }
}'
