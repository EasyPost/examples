import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

shipment = client.shipment.retrieve("shp_...")

bought_shipment = client.shipment.buy(
    shipment.id,
    rate=shipment.lowest_rate(),
    insurance=249.99,
)

print(bought_shipment)
