curl -X POST https://api.easypost.com/v2/referral_customers \
  -u "$PARTNER_API_KEY": \
  -H "Content-Type: application/json" \
  -d '{
      "user": {
        "name": "Firstname Lastname",
        "email": "email@example.com",
        "phone_number": "8888888888"
      }
  }'
