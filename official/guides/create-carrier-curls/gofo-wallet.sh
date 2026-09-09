curl -X POST https://api.easypost.com/v2/carrier_accounts/open \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "GofoWalletAccount",
    "reference": "GOFO Wallet Account",
    "description": "GOFO Wallet Account",
    "origin_hub": "VALUE"
  }
}'
