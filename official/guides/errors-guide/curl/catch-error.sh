curl -X POST https://api.easypost.com/v2/addresses \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "address": {
    "street1": "..."
  },
  "verify_strict": "true"
}'
