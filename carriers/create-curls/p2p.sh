curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "P2PAccount",
    "description": "P2PAccount",
    "credentials": {
      "api_key": "VALUE",
      "customer_id": "VALUE",
      "username": "VALUE"
    },
    "test_credentials": {
      "api_key": "VALUE",
      "customer_id": "VALUE",
      "username": "VALUE"
    }
  }
}'
