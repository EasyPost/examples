import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

shipment = client.shipment.retrieve("shp_...")

smart_rates = client.shipment.get_smart_rates(shipment.id)

print(smart_rates)
