curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "DoorDashAccount",
    "description": "DoorDashAccount",
    "credentials": {
      "developer_id": "VALUE",
      "key_id": "VALUE",
      "pickup_external_business_id": "VALUE",
      "signing_secret": "VALUE"
    },
    "test_credentials": {
      "developer_id": "VALUE",
      "key_id": "VALUE",
      "pickup_external_business_id": "VALUE",
      "signing_secret": "VALUE"
    }
  }
}'
