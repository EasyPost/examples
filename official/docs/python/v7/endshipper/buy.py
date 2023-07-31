import easypost
import os

easypost.api_key = os.getenv("EASYPOST_API_KEY")

shipment = easypost.Shipment.retrieve("shp_...")

shipment.buy(
    rate=shipment.lowest_rate(),
    end_shipper_id="es_...",
)

print(shipment)
