curl -X POST https://api.easypost.com/v2/carrier_accounts/open \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "UniUniWalletAccount",
    "description": "UniUniWalletAccount",
    "credentials": {
      "customer_number": "VALUE"
    },
    "payment_mode": "aggregation"
  }
}'
