curl -X POST https://api.easypost.com/v2/carrier_accounts/open \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "UpsDapAccount",
    "description": "VALUE",
    "name": "VALUE",
    "title": "VALUE",
    "company": "VALUE",
    "street1": "VALUE",
    "street2": "VALUE",
    "city": "VALUE",
    "state": "VALUE",
    "postal_code": "VALUE",
    "country": "VALUE",
    "website": "VALUE",
    "email": "VALUE",
    "phone": "VALUE"
  }
}'
