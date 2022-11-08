curl -X POST https://api.easypost.com/v2/shipments \
-u $EASYPOST_API_KEY: \
-H 'Content-Type: application/json' \
-d '{
  "shipment": {
    "to_address": {
      "name": "Tim Canterbury",
      "company": "Wernham Hogg",
      "street1": "118 Clippenham Lane",
      "city": "Slough",
      "zip": "SL15BE",
      "country": "GB"
    },
    "from_address": {
      "company": "EasyPost",
      "street1": "5th Floor",
      "city": "San Francisco",
      "state": "CA",
      "zip": "94104",
      "country": "US",
      "phone": "415-528-7555"
    },
    "parcel": {
      "length": "9",
      "width": "6",
      "height": "3",
      "weight": "20"
    },
    "customs_info": {
      "id": "cstinfo_..."
    }
  }
}'
