import easypost
easypost.api_key = "EASYPOST_API_KEY"

order = easypost.Order.retrieve("order_...")
order.buy(carrier="FedEx", service="FEDEX_GROUND")

print(order)
