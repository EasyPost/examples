curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "type": "SendleAccount",
  "description": "SendleAccount",
  "carrier_account": {
    "credentials": {
      "api_key": "VALUE",
      "user_id": "VALUE"
    },
    "test_credentials": {
      "api_key": "VALUE",
      "user_id": "VALUE"
    }
  }
}'
