import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

shipment = client.shipment.retrieve("shp_...")

shipment_with_regenerated_rates = client.shipment.regenerate_rates(shipment.id)

print(shipment_with_regenerated_rates)
