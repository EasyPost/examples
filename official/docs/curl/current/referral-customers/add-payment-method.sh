curl -X POST "https://api.easypost.com/beta/referral_customers/payment_method" \
  -u "$RC_API_KEY": \
  -H "Content-Type: application/json" \
  -d '{
      "payment_method": {
        "stripe_customer_id": "cus_Ab123XX",
        "payment_method_reference": "card_Ab123XX",
        "priority": "primary"
      }
  }'
