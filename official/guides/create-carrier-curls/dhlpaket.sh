curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "type": "DhlPaketAccount",
  "description": "DhlPaketAccount",
  "carrier_account": {
    "credentials": {
      "account_number": "VALUE",
      "cig_password": "VALUE",
      "cig_username": "VALUE",
      "contract_id": "VALUE",
      "retoure_password": "VALUE",
      "retoure_username": "VALUE",
      "tnt_password": "VALUE",
      "tnt_username": "VALUE"
    },
    "test_credentials": {
      "account_number": "VALUE",
      "cig_password": "VALUE",
      "cig_username": "VALUE",
      "contract_id": "VALUE",
      "retoure_password": "VALUE",
      "retoure_username": "VALUE",
      "tnt_password": "VALUE",
      "tnt_username": "VALUE"
    }
  }
}'
