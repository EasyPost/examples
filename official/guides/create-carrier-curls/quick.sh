curl -X POST https://www.easypost.com/api/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "type": "QuickAccount"
  "description: "QuickCourierAccount",
    "billToEasyPost": false,
      "credentials": {
        "username": "<username>",
        "password": "<password>"
      },
      "test_credentials": {},
}'
