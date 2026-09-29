import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

order = client.order.buy(
    "order_...",
    carrier="FedEx",
    service="FEDEX_GROUND",
)

print(order)
