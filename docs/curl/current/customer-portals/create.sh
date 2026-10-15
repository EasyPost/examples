curl -X POST https://api.easypost.com/v2/customer_portal/account_link \
  -u "EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
    "session_type": "account_management",
    "user_id": "user_...",
    "refresh_url": "https://example.com/refresh",
    "return_url": "https://example.com/return",
    "metadata": {"target": "wallet"}
  }'
