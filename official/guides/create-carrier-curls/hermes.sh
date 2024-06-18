curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "type": "HermesAccount",
  "description": "HermesAccount",
  "carrier_account": {
    "credentials": {
      "api_key": "VALUE",
      "auth_id": "VALUE",
      "auth_secret": "VALUE",
      "client_id": "VALUE",
      "client_name": "VALUE",
      "password": "VALUE",
      "username": "VALUE"
    }
  }
}'
