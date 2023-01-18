curl -X POST https://api.easypost.com/v2/carrier_accounts \
-u "$EASYPOST_API_KEY": \
-H 'Content-Type: application/json' \
-d '{
  "type": "SfExpressAccount",
  "description": "SfExpressAccount",
  "carrier_account": {
    "credentials": {
      "checkword": "VALUE",
      "customer_code": "VALUE",
      "customer_id": "VALUE"
    },
    "test_credentials": {
      "checkword": "VALUE",
      "customer_code": "VALUE",
      "customer_id": "VALUE"
    }
  }
}'
