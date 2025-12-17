curl -X POST https://api.easypost.com/v2/carrier_accounts/register_oauth \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account_oauth_registrations": {
    "type": "AmazonShippingAccount",
    "description": "My Shipping Account (optional)",
    "reference": "Internal reference id (optional)",
    "return_to_url": "https://example.com (optional)"
  }
}'
