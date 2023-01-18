curl -X POST https://api.easypost.com/v2/carrier_accounts \
-u "$EASYPOST_API_KEY": \
-H 'Content-Type: application/json' \
-d '{
  "type": "AmazonMwsAccount",
  "description": "AmazonMwsAccount",
  "carrier_account": {
    "credentials": {
      "access_key_id": "VALUE",
      "merchant_id": "VALUE",
      "secret_key": "VALUE"
    }
  }
}'
