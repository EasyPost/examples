import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

shipment = client.shipment.retrieve("shp_...")

print(shipment)
