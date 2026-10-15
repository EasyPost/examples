import easypost

easypost.api_key = "EASYPOST_API_KEY"

order = easypost.Order.retrieve("order_...")

print(order)
