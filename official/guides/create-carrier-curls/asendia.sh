curl -X POST https://api.easypost.com/v2/carrier_accounts \
-u "$EASYPOST_API_KEY": \
-H 'Content-Type: application/json' \
-d '{
  "type": "AsendiaAccount",
  "description": "AsendiaAccount",
  "carrier_account": {
    "credentials": {
      "account_number": "VALUE",
      "company_name": "VALUE",
      "epacket": "VALUE",
      "ftp_password": "VALUE",
      "ftp_username": "VALUE",
      "internationalexpress": "VALUE",
      "ipa": "VALUE",
      "isal": "VALUE",
      "other": "VALUE",
      "pmei": "VALUE",
      "pmi": "VALUE",
      "prioritytracked": "VALUE"
    }
  }
}'
