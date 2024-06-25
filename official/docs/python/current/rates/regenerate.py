import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

shipment = client.shipment.regenerate_rates("shp_...")

print(shipment)
