import easypost


easypost.api_key = "EASYPOST_API_KEY"

payment_methods = easypost.Billing.retrieve_payment_methods()

print(payment_methods)
