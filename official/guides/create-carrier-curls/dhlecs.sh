curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "type": "DhlEcsAccount",
  "description": "DhlEcsAccount",
  "carrier_account": {
    "credentials": {
      "client_id": "VALUE",
      "client_secret": "VALUE",
      "distribution_center": "VALUE",
      "pickup_id": "VALUE"
    },
    "test_credentials": {
      "client_id": "VALUE",
      "client_secret": "VALUE",
      "distribution_center": "VALUE",
      "pickup_id": "VALUE"
    }
  }
}'
