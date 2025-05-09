curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "ParcllAccount",
    "description": "ParcllAccount",
    "credentials": {
      "api_key": "VALUE",
      "origin_hub": "VALUE",
      "user_id": "VALUE"
    },
    "test_credentials": {
      "api_key": "VALUE",
      "origin_hub": "VALUE",
      "user_id": "VALUE"
    }
  }
}'
