curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "type": "MaerskAccount",
  "description": "MaerskAccount",
  "carrier_account": {
    "reference": "my-reference",
    "credentials": {
      "account_key": "VALUE",
      "account_number": "VALUE",
    },
    "test_credentials": {
      "account_key": "VALUE",
      "account_number": "VALUE",
    }
  }
}'
