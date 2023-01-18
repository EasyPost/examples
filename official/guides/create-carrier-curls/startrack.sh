curl -X POST https://api.easypost.com/v2/carrier_accounts \
-u "$EASYPOST_API_KEY": \
-H 'Content-Type: application/json' \
-d '{
  "type": "StarTrackAccount",
  "description": "StarTrackAccount",
  "carrier_account": {
    "credentials": {
      "account_number": "VALUE",
      "api_key": "VALUE",
      "api_secret": "VALUE",
      "print_as_you_go": "VALUE"
    }
  }
}'
