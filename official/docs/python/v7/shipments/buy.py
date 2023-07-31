import easypost
import os

easypost.api_key = os.getenv("EASYPOST_API_KEY")

shipment = easypost.Shipment.retrieve("shp_...")

shipment.buy(
    rate=shipment.lowest_rate(),
    insurance=249.99,
)

print(shipment)
