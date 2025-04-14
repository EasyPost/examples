curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "CourierExpressAccount",
    "description": "CourierExpressAccount",
    "credentials": {
      "api_key": "VALUE",
      "shipper_id": "VALUE"
    },
    "test_credentials": {
      "api_key": "VALUE",
      "shipper_id": "VALUE"
    }
  }
}'
