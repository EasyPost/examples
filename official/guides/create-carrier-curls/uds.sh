curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "type": "UdsAccount",
  "description": "UdsAccount",
  "carrier_account": {
    "credentials": {
      "ftp_password": "VALUE",
      "ftp_username": "VALUE"
    }
  }
}'
