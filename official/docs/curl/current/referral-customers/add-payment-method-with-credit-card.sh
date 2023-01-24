curl -X POST "https://api.easypost.com/beta/referral_customers/payment_method" \
  -u "$REFERRAL_USER_API_KEY": \
  -H "Content-Type: application/json" \
  -d '{
      "payment_method": {
        "stripe_customer_id": "cus_...",
        "payment_method_reference": "card_...",
        "priority": "primary"
      }
  }'
