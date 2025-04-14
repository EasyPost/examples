curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "DeutschePostUKAccount",
    "description": "DeutschePostUKAccount",
    "credentials": {
      "account_number": "VALUE",
      "client_id": "VALUE",
      "client_secret": "VALUE"
    },
    "test_credentials": {
      "account_number": "VALUE",
      "client_id": "VALUE",
      "client_secret": "VALUE"
    }
  }
}'
