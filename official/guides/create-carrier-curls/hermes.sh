curl -X POST https://api.easypost.com/v2/carrier_accounts \
-u "$EASYPOST_API_KEY": \
-H 'Content-Type: application/json' \
-d '{
  "type": "HermesAccount",
  "description": "HermesAccount",
  "carrier_account": {
    "credentials": {
      "client_id": "VALUE",
      "client_licence": "VALUE",
      "client_name": "VALUE",
      "group_id": "VALUE",
      "password": "VALUE",
      "username": "VALUE"
    }
  }
}'
