curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "OmniParcelAccount",
    "description": "OmniParcelAccount",
    "credentials": {
      "api_access_key": "VALUE",
      "return_api_access_key": "VALUE"
    },
    "test_credentials": {
      "api_access_key": "VALUE",
      "return_api_access_key": "VALUE"
    }
  }
}'
