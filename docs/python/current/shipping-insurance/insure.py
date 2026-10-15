import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

shipment = client.shipment.insure("shp_...", amount=100)

print(shipment)
