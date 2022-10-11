curl -X POST "https://api.easypost.com/v2/credit_cards" \
  -u "<REFERRAL_USER_API_KEY>:" \
  -H "Content-Type: application/json" \
  -d '{
    "credit_card": {
      "stripe_object_id":"tok_...",
      "priority":"primary"
    }
  }'
