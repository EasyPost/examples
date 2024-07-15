import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

estimated_delivery_dates = client.shipment.recommend_ship_date(
    "shp_...",
    desired_delivery_date="YYYY-MM-DD",
)

print(estimated_delivery_dates)
