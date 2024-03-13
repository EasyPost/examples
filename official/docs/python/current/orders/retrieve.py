import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

order = client.order.retrieve("order_...")

print(order)
