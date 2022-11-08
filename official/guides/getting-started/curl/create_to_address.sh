curl -X POST https://api.easypost.com/v2/addresses \
-u $EASYPOST_API_KEY: \
-H 'Content-Type: application/json' \
-d '{
  "address": {
    "name": "George Costanza",
    "company": "Vandelay Industries",
    "street1": "1 E 161st St.",
    "city": "Bronx",
    "state": "NY",
    "zip": "10451"
  }
}'
