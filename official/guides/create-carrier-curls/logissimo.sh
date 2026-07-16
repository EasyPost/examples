curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "LogissimoAccount",
    "description": "LogissimoAccount",
    "credentials": {
      "api_key": "VALUE",
      "api_username": "VALUE",
      "client_id": "VALUE",
      "password": "VALUE",
      "shipper_account_number": "VALUE"
    },
    "test_credentials": {
      "api_key": "VALUE",
      "api_username": "VALUE",
      "client_id": "VALUE",
      "password": "VALUE",
      "shipper_account_number": "VALUE"
    }
  }
}'
