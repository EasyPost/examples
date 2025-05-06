curl -X POST "https://api.easypost.com/v2/bank_accounts" \
  -u "$REFERRAL_USER_API_KEY:" \
  -H "Content-Type: application/json" \
  -d '{
    "financial_connections_id": "fca_...",
    "mandate_data": {
      "ip_address": "127.0.0.1",
      "user_agent": "Mozilla/5.0",
      "accepted_at": 1722510730,
    },
    "priority": "primary"
  }'
