curl -X POST https://api.easypost.com/v2/shipments/shp_.../luma \
  -u "EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
    "ruleset_name": "ruleset_name",
    "planned_ship_date": "YYYY-MM-DD"
    "deliver_by_date": "YYYY-MM-DD"
  }'
