curl -X PATCH https://api.easypost.com/v2/webhooks/hook_... \
  -u "EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
    "webhook_secret": "my_secret",
    "custom_headers": [{
      "name": "X-Header-Name",
      "value": "header_value"
    }],
  }'
