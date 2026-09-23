curl -X POST https://api.easypost.com/v2/carrier_accounts/open \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "VehoWalletAccount",
    "reference": "Veho Wallet Account",
    "description": "Veho Wallet Account",
    "company": "VALUE",
    "agreed_to_terms_at": "VALUE"
  }
}'
