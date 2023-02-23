curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
    "carrier_account": {
      "type": "DhlEcsAccount",
      "description": "CA Location DHL eCommerce Solutions Account",
      "reference": "my-reference",
      "credentials": {
        "client_id": "123456",
        "client_secret": "123abc",
        "distribution_center": "USLAX1",
        "pickup_id": "123456"
      },
      "test_credentials": {
        "client_id": "123456",
        "client_secret": "123abc",
        "distribution_center": "USLAX1",
        "pickup_id": "123456"
      }
    }
  }'
