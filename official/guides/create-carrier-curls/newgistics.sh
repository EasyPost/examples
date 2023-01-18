curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "type": "NewgisticsAccount",
  "description": "NewgisticsAccount",
  "carrier_account": {
    "credentials": {
      "client_facility_id": "VALUE",
      "client_id": "VALUE",
      "client_secret": "VALUE",
      "fulfiller_facility_id": "VALUE",
      "merchant_id": "VALUE",
      "tracking_api_key": "VALUE"
    },
    "test_credentials": {
      "client_facility_id": "VALUE",
      "client_id": "VALUE",
      "client_secret": "VALUE",
      "fulfiller_facility_id": "VALUE",
      "merchant_id": "VALUE",
      "tracking_api_key": "VALUE"
    }
  }
}'
