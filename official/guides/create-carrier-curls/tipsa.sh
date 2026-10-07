curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "TipsaAccount",
    "description": "TipsaAccount",
    "credentials": {
      "agency_code": "VALUE",
      "customer_code": "VALUE",
      "password": "VALUE"
    }
  }
}'
