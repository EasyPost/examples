import easypost
import os

client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

shipments = client.shipment.all(
    page_size=5,
)

print(shipments)
