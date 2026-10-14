curl -X POST https://api.easypost.com/v2/smartrate/deliver_by \
  -u "EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
    "from_zip": "10001",
    "planned_ship_date": "2024-07-18",
    "to_zip": "10002",
    "carriers": [UPS],
  }'
