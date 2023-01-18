curl -X POST https://api.easypost.com/v2/carrier_accounts \
-u "$EASYPOST_API_KEY": \
-H 'Content-Type: application/json' \
-d '{
  "type": "DhlParcelAccount",
  "description": "DhlParcelAccount",
  "carrier_account": {
    "credentials": {
      "account_number": "VALUE",
      "api_key": "VALUE",
      "user_id": "VALUE"
    },
    "test_credentials": {
      "account_number": "VALUE",
      "api_key": "VALUE",
      "user_id": "VALUE"
    }
  }
}'
