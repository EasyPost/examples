import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

shipment = client.shipment.retrieve("shp_...")

estimated_delivery_dates = shipment.retrieve_estimated_delivery_date(planned_ship_date="YYYY-MM-DD")

print(estimated_delivery_dates)
