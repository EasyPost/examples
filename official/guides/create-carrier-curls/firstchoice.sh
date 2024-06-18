curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "type": "FirstChoiceAccount",
  "description": "FirstChoiceAccount",
  "carrier_account": {
    "credentials": {
      "account_number": "VALUE",
      "api_key": "VALUE",
      "customer_code": "VALUE",
      "customer_key": "VALUE",
      "password": "VALUE",
      "username": "VALUE"
    },
    "test_credentials": {
      "account_number": "VALUE",
      "api_key": "VALUE",
      "customer_code": "VALUE",
      "customer_key": "VALUE",
      "password": "VALUE",
      "username": "VALUE"
    }
  }
}'
