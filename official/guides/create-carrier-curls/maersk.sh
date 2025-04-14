curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "MaerskAccount",
    "description": "MaerskAccount",
    "credentials": {
      "account_key": "VALUE",
      "account_number": "VALUE"
    }
  }
}'
