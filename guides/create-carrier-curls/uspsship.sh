curl -X POST https://api.easypost.com/v2/carrier_accounts/register_oauth \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "UspsShipAccount",
    "description": "UspsShipAccount",
    "credentials": {
      "account_number": "VALUE",
      "address_city": "VALUE",
      "address_state": "VALUE",
      "address_street": "VALUE",
      "address_zip": "VALUE",
      "client_id": "VALUE",
      "client_secret": "VALUE",
      "company_name": "VALUE",
      "contract_number": "VALUE",
      "customer_registration_id": "VALUE",
      "email": "VALUE",
      "mailer_id": "VALUE",
      "manifest_id": "VALUE",
      "partner_oauth_url": "VALUE",
      "phone": "VALUE",
      "platform_account_number": "VALUE",
      "refresh_token": "VALUE",
      "returns_mailer_id": "VALUE",
      "secondary_account_number": "VALUE",
      "shipper_id": "VALUE"
    }
  }
}'
