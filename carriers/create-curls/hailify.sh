curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "HailifyAccount",
    "description": "HailifyAccount",
    "credentials": {
      "partner_id": "VALUE"
    },
    "test_credentials": {
      "partner_id": "VALUE"
    }
  }
}'
