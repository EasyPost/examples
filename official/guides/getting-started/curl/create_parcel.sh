curl -X POST https://api.easypost.com/v2/parcels \
-u $EASYPOST_API_KEY: \
-H 'Content-Type: application/json' \
-d '{
  "parcel": {
    "length": "9",
    "width": "6",
    "height": "2",
    "weight": "10"
  }
}'
