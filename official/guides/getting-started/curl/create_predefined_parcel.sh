curl -X POST https://api.easypost.com/v2/parcels \
-u $EASYPOST_API_KEY: \
-H 'Content-Type: application/json' \
-d '{
  "parcel": {
    "predefined_package": "FlatRateEnvelope",
    "weight": "10"
  }
}'
