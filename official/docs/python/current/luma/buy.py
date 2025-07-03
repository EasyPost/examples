import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

shipment = client.shipment.retrieve("shp_...")

shipment = client.shipment.luma(
    shipment.id,
    ruleset_name="ruleset_name",
    planned_ship_date="2025-07-03",
    deliver_by_date="2025-07-06",
)

print(shipment)
