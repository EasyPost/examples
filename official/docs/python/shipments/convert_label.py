import easypost


easypost.api_key = "EASYPOST_API_KEY"

shipment = easypost.Shipment.retrieve("shp_...")

shipment.label(file_format="ZPL")

print(shipment)
