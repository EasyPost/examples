curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "SmartKargoAccount",
    "description": "SmartKargoAccount",
    "credentials": {
      "account_number": "VALUE"
    },
    "test_credentials": {
      "account_number": "VALUE"
    }
  }
}'
