import easypost
import os

client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

shipment = client.shipment.retrieve("shp_...")

estimated_delivery_dates = client.shipment.retrieve_estimated_delivery_date(
    shipment.id,
    planned_ship_date="YYYY-MM-DD",
)

print(estimated_delivery_dates)
