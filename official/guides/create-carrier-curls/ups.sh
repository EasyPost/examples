curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "type": "UpsAccount",
  "description": "UpsAccount",
  "registration_data": {
    "account_number": "VALUE",
    "city": "VALUE",
    "company": "VALUE",
    "country": "VALUE",
    "email": "VALUE",
    "name": "VALUE",
    "phone": "VALUE",
    "postal_code": "VALUE",
    "state": "VALUE",
    "street1": "VALUE",
    "title": "VALUE",
    "website": "VALUE",
    "invoice_amount": "VALUE",
    "invoice_control_id": "VALUE",
    "invoice_currency": "VALUE",
    "invoice_date": "VALUE",
    "invoice_number": "VALUEr"
  }
}'
