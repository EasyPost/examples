import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

# Purchase and insure a shipment
shipment = easypost.shipment.retrieve("shp_123")
client.shipment.buy(
    shipment.id,
    rate=shipment.lowest_rate(),
    insurance=99.99,
)
