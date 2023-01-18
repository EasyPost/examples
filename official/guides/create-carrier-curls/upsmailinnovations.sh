curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "type": "UpsMailInnovationsAccount",
  "description": "UpsMailInnovationsAccount",
  "carrier_account": {
    "credentials": {
      "account_number": "VALUE",
      "customer_guid": "VALUE",
      "customer_id": "VALUE",
      "password": "VALUE",
      "user_id": "VALUE"
    }
  }
}'
