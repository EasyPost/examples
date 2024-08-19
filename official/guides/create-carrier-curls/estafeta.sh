curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "type": "EstafetaAccount",
  "description": "EstafetaAccount",
  "carrier_account": {
    "credentials": {
      "customer_number": "VALUE",
      "hub_id": "VALUE"
    }
  }
}'
