curl -X POST https://api.easypost.com/v2/carrier_accounts/register \
-u "$EASYPOST_API_KEY": \
-H 'Content-Type: application/json' \
-d '{
  "type": "FedexAccount",
  "description": "FedexAccount",
  "registration_data": {
    "shipping_city": "VALUE",
    "shipping_country_code": "VALUE",
    "shipping_postal_code": "VALUE",
    "shipping_state": "VALUE",
    "shipping_streets": "VALUE",
    "corporate_city": "VALUE",
    "corporate_company_name": "VALUE",
    "corporate_country_code": "VALUE",
    "corporate_email_address": "VALUE",
    "corporate_first_name": "VALUE",
    "corporate_job_title": "VALUE",
    "corporate_last_name": "VALUE",
    "corporate_phone_number": "VALUE",
    "corporate_postal_code": "VALUE",
    "corporate_state": "VALUE",
    "corporate_streets": "VALUE",
    "account_number": "VALUE"
  }
}'
