curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "SpeedXAccount",
    "description": "SpeedXAccount",
    "credentials": {
      "api_key": "VALUE",
      "pickup_account_num": "VALUE"
    },
    "test_credentials": {
      "api_key": "VALUE",
      "pickup_account_num": "VALUE"
    }
  }
}'
