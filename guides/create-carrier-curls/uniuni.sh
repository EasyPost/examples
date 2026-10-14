curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "UniUniAccount",
    "description": "UniUniAccount",
    "credentials": {
      "client_id": "VALUE",
      "client_secret": "VALUE",
      "customer_number": "VALUE",
      "pickup_warehouse": "VALUE"
    }
  }
}'
