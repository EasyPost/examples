import os

import easypost


easypost.api_key = os.getenv("EASYPOST_API_KEY")

shipment = easypost.Shipment.retrieve("shp_...")

shipment.buy(
    rate="rate_...",
    end_shipper_id="es_...",
)

print(shipment)
