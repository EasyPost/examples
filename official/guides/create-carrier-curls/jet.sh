curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "JetAccount",
    "description": "JetAccount",
    "credentials": {
      "password": "VALUE",
      "username": "VALUE"
    },
    "test_credentials": {
      "password": "VALUE",
      "username": "VALUE"
    }
  }
}'
