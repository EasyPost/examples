curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "CttExpressAccount",
    "description": "CttExpressAccount",
    "credentials": {
      "authentication_id": "VALUE",
      "client_id": "VALUE",
      "contract_id": "VALUE",
      "distribution_channel_id": "VALUE",
      "user_id": "VALUE"
    },
    "test_credentials": {
      "authentication_id": "VALUE",
      "client_id": "VALUE",
      "contract_id": "VALUE",
      "distribution_channel_id": "VALUE",
      "user_id": "VALUE"
    }
  }
}'
