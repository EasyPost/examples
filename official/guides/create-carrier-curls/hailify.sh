curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "type": "HailifyAccount",
  "description": "HailifyAccount",
  "carrier_account": {
    "credentials": {
      "partner_id": "VALUE"
    },
    "test_credentials": {
      "partner_id": "VALUE"
    }
  }
}'
