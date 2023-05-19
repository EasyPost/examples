import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

shipment = client.shipment.retrieve("shp_...")

insured_shipment = client.shipment.insure(shipment.id, amount=100)

print(insured_shipment)
