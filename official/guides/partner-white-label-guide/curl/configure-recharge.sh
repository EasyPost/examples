curl -X PUT "https://api.easypost.com/v2/users" \
  -u "<REFERRAL_USER_API_KEY>:" \
  -H "Content-Type: application/json" \
  -d '{
  "recharge_amount": "100.00",
  "secondary_recharge_amount": "50.00",
  "recharge_threshold": "25.00",
}'
