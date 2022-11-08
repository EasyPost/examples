curl -X PUT "https://api.easypost.com/v2/referral_customers" \
-u "<REFERRAL_USER_API_KEY>:" \
-H "Content-Type: application/json" \
-d '{
  "user": {
  "email": "email@example.com"
  }
}'
