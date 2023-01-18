curl -X POST https://api.easypost.com/v2/carrier_accounts \
-u "$EASYPOST_API_KEY": \
-H 'Content-Type: application/json' \
-d '{
  "type": "DpdUkAccount",
  "description": "DpdUkAccount",
  "carrier_account": {
    "credentials": {
      "account_number": "VALUE",
      "password": "VALUE",
      "username": "VALUE"
    }
  }
}'
