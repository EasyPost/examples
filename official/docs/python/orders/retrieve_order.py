import os

import easypost


easypost.api_key = os.getenv("EASYPOST_API_KEY")

order = easypost.Order.retrieve("order_...")

print(order)
