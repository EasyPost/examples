curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "EstafetaAccount",
    "description": "EstafetaAccount",
    "credentials": {
      "buy_api_key": "VALUE",
      "buy_client_id": "VALUE",
      "buy_client_secret": "VALUE",
      "customer_number": "VALUE",
      "hub_id": "VALUE",
      "rate_api_key": "VALUE",
      "rate_client_id": "VALUE",
      "rate_client_secret": "VALUE",
      "track_api_key": "VALUE",
      "track_client_id": "VALUE",
      "track_client_secret": "VALUE"
    },
    "test_credentials": {
      "buy_api_key": "VALUE",
      "buy_client_id": "VALUE",
      "buy_client_secret": "VALUE",
      "customer_number": "VALUE",
      "hub_id": "VALUE",
      "rate_api_key": "VALUE",
      "rate_client_id": "VALUE",
      "rate_client_secret": "VALUE",
      "track_api_key": "VALUE",
      "track_client_id": "VALUE",
      "track_client_secret": "VALUE"
    }
  }
}'
