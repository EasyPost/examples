curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "type": "SwyftAccount",
  "description": "SwyftAccount",
  "carrier_account": {
    "credentials": {
      "password": "VALUE"
    },
    "test_credentials": {
      "password": "VALUE"
    }
  }
}'
