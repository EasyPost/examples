import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

shipment = client.shipment.buy_luma(
    "shp_...",
    ruleset_name="ruleset_...",
    planned_ship_date="2025-07-24",
    deliver_by_date="2025-07-26",
)

print(shipment)
