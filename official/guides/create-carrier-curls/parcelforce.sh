curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "ParcelForceAccount",
    "description": "ParcelForceAccount",
    "credentials": {
      "account_number": "VALUE",
      "department_id": "VALUE",
      "password": "VALUE",
      "username": "VALUE"
    },
    "test_credentials": {
      "account_number": "VALUE",
      "department_id": "VALUE",
      "password": "VALUE",
      "username": "VALUE"
    }
  }
}'
