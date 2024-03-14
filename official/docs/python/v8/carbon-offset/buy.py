import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

shipment = client.shipment.retrieve("shp_...")
bought_shipment = client.shipment.buy(
    shipment.id,
    rate=shipment.lowest_rate(),
    insurance=249.99,
    with_carbon_offset=True,
)

print(bought_shipment)
