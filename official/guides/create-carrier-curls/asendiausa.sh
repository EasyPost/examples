curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "type": "AsendiaUsaAccount",
  "description": "AsendiaUsaAccount",
  "carrier_account": {
    "credentials": {
      "account_number": "VALUE",
      "api_key": "VALUE",
      "carrier_facility": "VALUE",
      "password": "VALUE",
      "sub_account_number": "VALUE",
      "username": "VALUE"
    },
    "test_credentials": {
      "account_number": "VALUE",
      "api_key": "VALUE",
      "carrier_facility": "VALUE",
      "password": "VALUE",
      "sub_account_number": "VALUE",
      "username": "VALUE"
    }
  }
}'
