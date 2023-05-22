import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

shipment = client.shipment.retrieve("shp_...")

refunded_shipment = client.shipment.refund(shipment.id)

print(refunded_shipment)
