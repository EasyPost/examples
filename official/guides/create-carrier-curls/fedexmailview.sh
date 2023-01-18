curl -X POST https://api.easypost.com/v2/carrier_accounts \
-u "$EASYPOST_API_KEY": \
-H 'Content-Type: application/json' \
-d '{
  "type": "FedexMailviewAccount",
  "description": "FedexMailviewAccount",
  "carrier_account": {
    "credentials": {
      "customer_id": "VALUE",
      "fimspremium": "VALUE",
      "fimsstandard": "VALUE",
      "mailviewlight": "VALUE",
      "mailviewpremium": "VALUE",
      "service_id": "VALUE"
    }
  }
}'
