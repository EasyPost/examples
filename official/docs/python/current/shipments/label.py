import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

shipment = client.shipment.label("shp_...", file_format="ZPL")

print(shipment)
