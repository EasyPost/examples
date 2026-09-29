import easypost
import os

client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

# Purchase and insure a shipment
shipment = client.shipment.retrieve("shp_...")
client.shipment.buy(
    shipment.id,
    rate=shipment.lowest_rate(),
    insurance=99.99,
)
