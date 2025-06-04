curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "OsmWorldwideV2Account",
    "description": "OsmWorldwideV2Account",
    "credentials": {
      "api_key": "VALUE",
      "client_id": "VALUE",
      "mailer_id": "VALUE",
      "rate_key": "VALUE"
    }
  }
}'
