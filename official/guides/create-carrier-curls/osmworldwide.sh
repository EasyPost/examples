curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "OsmWorldwideAccount",
    "description": "OsmWorldwideAccount",
    "credentials": {
      "account_number": "VALUE",
      "aws_sftp_username": "VALUE",
      "company_name": "VALUE",
      "facility_code": "VALUE",
      "mailer_id": "VALUE"
    }
  }
}'
