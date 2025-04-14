curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "EstafetaAccount",
    "description": "EstafetaAccount",
    "credentials": {
      "customer_number": "VALUE",
      "hub_id": "VALUE"
    }
  }
}'
