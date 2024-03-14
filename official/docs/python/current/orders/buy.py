import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

order = client.order.retrieve("order_...")
bought_order = client.order.buy(
    order.id,
    carrier="FedEx",
    service="FEDEX_GROUND",
)

print(order)
