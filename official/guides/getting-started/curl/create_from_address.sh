curl -X POST https://api.easypost.com/v2/addresses \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "address": {
    "company": "EasyPost",
    "street1": "417 Montgomery Street",
    "street2": "5th Floor",
    "city": "San Francisco",
    "state": "CA",
    "zip": "94104",
    "phone": "415-528-7555"
  }
}'
