curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "type": "DhlExpressAccount",
  "description": "DhlExpressAccount",
  "carrier_account": {
    "credentials": {
      "account_number": "VALUE",
      "country": "VALUE",
      "is_reseller": "VALUE",
      "password": "VALUE",
      "site_id": "VALUE"
    }
  }
}'
