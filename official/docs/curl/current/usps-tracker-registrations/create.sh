curl -X POST https://api.easypost.com/v2/carrier_claims/usps_tracker_registrations \
  -u "EASYPOST_API_KEY": \
  -H "Content-Type: application/json" \
  -d '{
  "tracker_registrations": [
    {
      "tracking_code": "9400111899223344556677",
      "product_value": "25.50",
      "recipient": {
        "first_name": "Jane",
        "last_name": "Doe"
      }
    }
  ]
}'
