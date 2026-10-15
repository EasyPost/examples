curl -X POST https://api.easypost.com/v2/trackers/batch \
  -u "EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
    "tracking_codes": [
      "EZ1000000001",
      "EZ1000000002"
    ]
  }'
