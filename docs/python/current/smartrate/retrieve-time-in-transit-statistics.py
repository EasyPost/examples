import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

smart_rates = client.shipment.get_smart_rates("shp_...")

print(smart_rates)
