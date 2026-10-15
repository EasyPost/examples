curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "GsoAccount",
    "description": "GsoAccount",
    "credentials": {
      "account_number": "VALUE",
      "password": "VALUE",
      "username": "VALUE"
    }
  }
}'
