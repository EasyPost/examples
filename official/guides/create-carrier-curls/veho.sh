curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "VehoAccount",
    "description": "VehoAccount",
    "credentials": {
      "api_key": "VALUE"
    },
    "test_credentials": {
      "api_key": "VALUE"
    }
  }
}'
