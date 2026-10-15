curl -x POST https://api.easypost.com/beta/referral_customers/refunds \
  -u "$REFERRAL_USER_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
        "refund_amount": 2000,
      }'
