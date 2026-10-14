curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "RoadieAccount",
    "description": "RoadieAccount",
    "credentials": {
      "access_token": "VALUE",
      "service_level": "VALUE"
    },
    "test_credentials": {
      "access_token": "VALUE",
      "service_level": "VALUE"
    }
  }
}'
