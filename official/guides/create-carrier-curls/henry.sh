curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "HenryAccount",
    "description": "HenryAccount",
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
