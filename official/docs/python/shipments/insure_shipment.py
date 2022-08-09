import easypost


easypost.api_key = "EASYPOST_API_KEY"

shipment = easypost.Shipment.retrieve("shp_...")
shipment.insure(amount=100)

print(shipment)
