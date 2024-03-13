import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

payment_methods = client.billing.retrieve_payment_methods()

print(payment_methods)
