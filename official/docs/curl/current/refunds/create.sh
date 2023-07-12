curl -X POST https://api.easypost.com/v2/refunds \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
    "refund": {
      "carrier": "USPS",
      "tracking_codes": [
        "EZ1000000001"
      ]
    }
  }'
