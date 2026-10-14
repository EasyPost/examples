curl -XPOST -H 'Content-Type: application/json' -H 'X-EasyPost-User-Id: <user-id>' https://api.easypost.com/v2/carrier_accounts -d '{
  "billToEasyPost": false,
  "credentials": {
    "developer_id": "VALUE",
    "key_id": "VALUE",
    "signing_secret": "VALUE",
    "pickup_external_business_id": "VALUE"
  },
  "test_credentials": {},
  "type": "DoorDashAccount"
}'
