curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "MrwAccount",
    "description": "MrwAccount",
    "credentials": {
      "department_code": "VALUE",
      "franchise_code": "VALUE",
      "password": "VALUE",
      "subscriber_code": "VALUE",
      "username": "VALUE"
    },
    "test_credentials": {
      "department_code": "VALUE",
      "franchise_code": "VALUE",
      "password": "VALUE",
      "subscriber_code": "VALUE",
      "username": "VALUE"
    }
  }
}'
