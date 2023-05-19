import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

shipment = client.shipment.retrieve("shp_...")

shipment_with_label = client.shipment.label(shipment.id, file_format="ZPL")

print(shipment_with_label)
