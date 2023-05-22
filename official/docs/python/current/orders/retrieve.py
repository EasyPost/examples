import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

order = client.order.retrieve("order_...")

print(order)
