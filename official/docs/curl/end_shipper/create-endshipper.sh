curl -X POST https://api.easypost.com/v2/end_shippers \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
    "address": {
      "name": "FOO BAR",
      "company": "BAZ",
      "street1": "164 TOWNSEND STREET UNIT 1",
      "street2": "UNIT 1",
      "city": "SAN FRANCISCO",
      "state": "CA",
      "zip": "94107",
      "country": "US",
      "phone": "555-555-5555",
      "email": "FOO@EXAMPLE.COM"
    }
  }'
