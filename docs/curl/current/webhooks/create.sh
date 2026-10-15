curl -X POST https://api.easypost.com/v2/webhooks \
  -u "EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
    "webhook": {
      "url": "example.com",
      "webhook_secret": "A1B2C3",
      "custom_headers": [{
        "name": "X-Header-Name",
        "value": "header_value"
      }],
    }
  }'
