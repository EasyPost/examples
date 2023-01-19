curl -X PUT "https://api.easypost.com/v2/referral_customers" \
  -u "$RC_API_KEY": \
  -H "Content-Type: application/json" \
  -d '{
      "user": {
        "email": "new_email@example.com"
      }
  }'
