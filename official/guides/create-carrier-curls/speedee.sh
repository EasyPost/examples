curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "type": "SpeedeeAccount",
  "description": "SpeedeeAccount",
  "carrier_account": {
    "credentials": {
      "account_number": "VALUE",
      "ftp_password": "VALUE",
      "ftp_username": "VALUE"
    }
  }
}'
