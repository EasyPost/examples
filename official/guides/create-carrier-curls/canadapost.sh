curl -X POST https://api.easypost.com/v2/carrier_accounts \
-u "$EASYPOST_API_KEY": \
-H 'Content-Type: application/json' \
-d '{
  "type": "CanadaPostAccount",
  "description": "CanadaPostAccount",
  "carrier_account": {
    "credentials": {
      "api_key": "VALUE",
      "contract_id": "VALUE",
      "customer_number": "VALUE",
      "has_credit_card": "VALUE",
      "not_platform": "VALUE"
    },
    "test_credentials": {
      "api_key": "VALUE",
      "contract_id": "VALUE",
      "customer_number": "VALUE",
      "has_credit_card": "VALUE",
      "not_platform": "VALUE"
    }
  }
}'
## REQUIRES CUSTOM WORKFLOW ##
