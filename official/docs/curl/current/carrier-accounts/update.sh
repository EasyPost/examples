curl -X PATCH https://api.easypost.com/v2/carrier_accounts/ca_... \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
    "carrier_account": {
      "description": "FL Location DHL eCommerce Solutions Account",
      "credentials": {
        "pickup_id": "abc123",
      }
    }
  }'
