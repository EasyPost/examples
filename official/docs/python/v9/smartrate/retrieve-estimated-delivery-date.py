import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

estimated_delivery_dates = client.shipment.retrieve_estimated_delivery_date(
    "shp_...",
    planned_ship_date="YYYY-MM-DD",
)

print(estimated_delivery_dates)
