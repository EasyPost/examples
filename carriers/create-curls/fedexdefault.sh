curl -X POST https://api.easypost.com/v2/carrier_accounts/open \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "FedexDefaultAccount",
    "name": "VALUE",
    "street1": "VALUE",
    "city": "VALUE",
    "state": "VALUE",
    "postal_code": "VALUE",
    "country": "VALUE",
    "phone": "VALUE",
    "email": "VALUE",
    "payment_mode": "aggregation"
  }
}'
