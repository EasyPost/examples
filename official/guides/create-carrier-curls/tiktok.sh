curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "TikTokAccount",
    "description": "TikTokAccount",
    "credentials": {
      "refresh_token": "VALUE",
      "shop_code": "VALUE"
    }
  }
}'
