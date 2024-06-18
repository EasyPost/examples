curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "type": "TollAccount",
  "description": "TollAccount",
  "carrier_account": {
    "credentials": {
      "account_number": "VALUE",
      "business_unit": "VALUE",
      "source_system_code": "VALUE"
    },
    "test_credentials": {
      "account_number": "VALUE",
      "business_unit": "VALUE",
      "source_system_code": "VALUE"
    }
  }
}'
