curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "MaerskAccount",
    "description": "Maersk Account",
    "reference": null,
    "credentials": {
      "first_name": "VALUE",
      "last_name": "VALUE",
      "company_name": "VALUE",
      "email": "VALUE",
      "phone": "VALUE",
      "daily_number_of_shipments": "VALUE",
      "channel": "VALUE",
      "accepted_terms": "true",
      "serial_number": "VALUE",
      "origin_address_line_1": "VALUE",
      "origin_address_line_2": "VALUE",
      "origin_postal_code": "VALUE",
      "origin_city": "VALUE",
      "origin_state": "VALUE",
      "billing_address_line_1": "VALUE",
      "billing_address_line_2": "VALUE",
      "billing_postal_code": "VALUE",
      "billing_city": "VALUE",
      "billing_state": "VALUE"
    },
    "test_credentials": {}
  }
}'
