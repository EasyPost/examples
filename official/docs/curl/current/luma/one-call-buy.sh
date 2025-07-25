curl -X POST https://api.easypost.com/v2/shipments/luma \
  -u "EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
    "shipment": {
      "to_address": {
        "name": "Dr. Steve Brule",
        "street1": "5744 Silverton Ave",
        "city": "McKinney",
        "state": "TX",
        "zip": "75070",
        "country": "US",
        "phone": "8573875756",
        "email": "dr_steve_brule@gmail.com"
      },
      "from_address": {
        "name": "EasyPost",
        "street1": "417 Montgomery Street",
        "street2": "5th Floor",
        "city": "San Francisco",
        "state": "CA",
        "zip": "94104",
        "country": "US",
        "phone": "4153334445",
        "email": "support@easypost.com"
      },
      "parcel": {
        "length": "20.2",
        "width": "10.9",
        "height": "5",
        "weight": "65.9"
      },
      "persist_label": true,
      "ruleset_name": "ruleset_...",
      "planned_ship_date": "2025-05-14",
      "deliver_by_date": "2025-05-16"
    }
  }'
