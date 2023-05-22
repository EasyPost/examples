import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

customs_item = client.customs_item.create(
    description="T-shirt",
    quantity=1,
    value=10,
    weight=5,
    hs_tariff_number="123456",
    origin_country="us",
)

print(customs_item)
