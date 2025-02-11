curl -X POST "https://api.easypost.com/beta/financial_connections_sessions" \
  -u "$REFERRAL_USER_API_KEY:" \
  -H "Content-Type: application/json" \
  -d '{
    "return_url": "https://www.yourwebsite.com/redirect"
  }'
