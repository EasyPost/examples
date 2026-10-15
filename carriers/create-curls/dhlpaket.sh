curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "DhlPaketAccount",
    "description": "DhlPaketAccount",
    "credentials": {
      "account_number": "VALUE",
      "contract_id": "VALUE",
      "gkp_password": "VALUE",
      "gkp_username": "VALUE"
    },
    "test_credentials": {
      "account_number": "VALUE",
      "contract_id": "VALUE",
      "gkp_password": "VALUE",
      "gkp_username": "VALUE"
    }
  }
}'
