curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "FedexCrossBorderAccount",
    "description": "FedexCrossBorderAccount",
    "credentials": {
      "api_key": "VALUE",
      "origin_hub": "VALUE"
    },
    "test_credentials": {
      "api_key": "VALUE",
      "origin_hub": "VALUE"
    }
  }
}'
