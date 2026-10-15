import easypost

easypost.api_key = "EASYPOST_API_KEY"

shipment = easypost.Shipment.retrieve("shp_...")
shipment.buy(rate=shipment.lowest_rate(), insurance=249.99, with_carbon_offset=True)

print(shipment)
