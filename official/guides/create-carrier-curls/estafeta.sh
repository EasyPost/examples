curl -X POST https://api.easypost.com/v2/carrier_accounts \
-u "$EASYPOST_API_KEY": \
-H 'Content-Type: application/json' \
-d '{
  "type": "EstafetaAccount",
  "description": "EstafetaAccount",
  "carrier_account": {
    "credentials": {
      "client_id": "VALUE",
      "customer_id": "VALUE",
      "customer_number": "VALUE",
      "hub_id": "VALUE",
      "password": "VALUE",
      "secret_key": "VALUE",
      "user_id": "VALUE",
      "username": "VALUE"
    },
    "test_credentials": {
      "client_id": "VALUE",
      "customer_id": "VALUE",
      "customer_number": "VALUE",
      "hub_id": "VALUE",
      "password": "VALUE",
      "secret_key": "VALUE",
      "user_id": "VALUE",
      "username": "VALUE"
    }
  }
}'
