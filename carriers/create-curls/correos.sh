curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "CorreosAccount",
    "description": "CorreosAccount",
    "credentials": {
      "api_client_id": "VALUE",
      "api_client_secret": "VALUE",
      "auth_client_id": "VALUE",
      "auth_client_secret": "VALUE",
      "client_number": "VALUE",
      "contract_number": "VALUE",
      "labeller_code": "VALUE"
    },
    "test_credentials": {
      "api_client_id": "VALUE",
      "api_client_secret": "VALUE",
      "auth_client_id": "VALUE",
      "auth_client_secret": "VALUE",
      "client_number": "VALUE",
      "contract_number": "VALUE",
      "labeller_code": "VALUE"
    }
  }
}'
