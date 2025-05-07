import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

shipment = client.shipment.refund("shp_...")

print(shipment)
