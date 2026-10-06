curl -X POST https://api.easypost.com/v2/embeddables/session \
  -u "EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
    "origin_host": "https://example.com",
    "user_id": "user_..."
  }'
