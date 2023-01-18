curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "type": "ColumbusLastMileAccount",
  "description": "ColumbusLastMileAccount",
  "carrier_account": {
    "credentials": {
      "password": "VALUE",
      "tracking_code_prefix": "VALUE",
      "username": "VALUE"
    },
    "test_credentials": {
      "password": "VALUE",
      "tracking_code_prefix": "VALUE",
      "username": "VALUE"
    }
  }
}'
