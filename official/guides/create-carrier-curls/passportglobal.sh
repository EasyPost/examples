curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "PassportGlobalAccount",
    "description": "PassportGlobalAccount",
    "credentials": {
      "api_key": "VALUE",
      "company_name": "VALUE",
      "email": "VALUE",
      "name": "VALUE",
      "phone": "VALUE"
    },
    "test_credentials": {
      "api_key": "VALUE",
      "company_name": "VALUE",
      "email": "VALUE",
      "name": "VALUE",
      "phone": "VALUE"
    }
  }
}'
