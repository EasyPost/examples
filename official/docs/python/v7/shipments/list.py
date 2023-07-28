import easypost
import os

easypost.api_key = os.getenv("EASYPOST_API_KEY")

shipments = easypost.Shipment.all(
    page_size=5,
)

print(shipments)
