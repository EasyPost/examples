import easypost

easypost.api_key = "EASYPOST_API_KEY"

shipment = easypost.Shipment.retrieve("shp_...")
shipment.regenerate_rates()

print(shipment)
