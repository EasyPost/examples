# Update the authenticated user
curl -X PATCH https://api.easypost.com/v2/users \
  -u "EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
    "user": {
      "recharge_threshold": "50.00"
    }
  }'

# Update a child user
curl -X PATCH https://api.easypost.com/v2/users/user_... \
  -u "EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
    "user": {
      "name": "Test Child"
    }
  }'
