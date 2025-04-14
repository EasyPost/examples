curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "UpsMailInnovationsAccount",
    "description": "UpsMailInnovationsAccount",
    "credentials": {
      "account_number": "VALUE",
      "customer_guid": "VALUE",
      "customer_id": "VALUE",
      "oauth_status": "VALUE",
      "partner_oauth_url": "VALUE",
      "password": "VALUE",
      "user_id": "VALUE"
    }
  }
}'
