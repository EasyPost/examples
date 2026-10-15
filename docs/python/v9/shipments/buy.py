import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

retrieved_shipment = client.shipment.retrieve("shp_...")

shipment = client.shipment.buy(
    retrieved_shipment.id,
    rate=retrieved_shipment.lowest_rate(),
    insurance=249.99,
)

print(shipment)
