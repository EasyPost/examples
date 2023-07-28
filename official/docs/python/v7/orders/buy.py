import easypost
import os

easypost.api_key = os.getenv("EASYPOST_API_KEY")

order = easypost.Order.retrieve("order_...")
order.buy(
    carrier="FedEx",
    service="FEDEX_GROUND",
)

print(order)
