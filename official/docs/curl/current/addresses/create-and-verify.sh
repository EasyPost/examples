curl -X POST https://api.easypost.com/v2/addresses/create_and_verify \
  -u "EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
    "address": {
      "street1": "000 unknown street",
      "city": "Not A City",
      "state": "ZZ",
      "zip": "00001",
      "country": "US",
      "email": "test@example.com",
      "phone": "5555555555"
    }
  }'
