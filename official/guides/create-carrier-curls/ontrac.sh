curl -X POST https://api.easypost.com/v2/carrier_accounts \
-u "$EASYPOST_API_KEY": \
-H 'Content-Type: application/json' \
-d '{
  "type": "OntracAccount",
  "description": "OntracAccount",
  "carrier_account": {
    "credentials": {
      "account_number": "VALUE",
      "password": "VALUE"
    },
    "test_credentials": {
      "account_number": "VALUE",
      "password": "VALUE"
    }
  }
}'
