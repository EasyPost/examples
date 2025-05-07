import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

bought_order = client.order.buy(
    "order_...",
    carrier="FedEx",
    service="FEDEX_GROUND",
)

print(order)
