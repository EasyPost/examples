curl -x POST "https://api.easypost.com/beta/referral_customers/refunds" \
  -u "RC_API_KEY:" \
  -H 'Content-Type: application/json' \
  -d '{
        "payment_log_id": "paylog..."
      }'
