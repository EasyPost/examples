# Fund wallet by using credit card payment method
curl -X POST https://api.easypost.com/v2/credit_cards/card_.../charges \
-u $EASYPOST_API_KEY: \
-H 'Content-Type: application/json' \
-d '{
  "amount": "2000"
}'

# Fund wallet by using bank account payment method
curl -X POST https://api.easypost.com/v2/bank_accounts/bank_.../charges \
-u $EASYPOST_API_KEY: \
-H 'Content-Type: application/json' \
-d '{
  "amount": "2000"
}'
