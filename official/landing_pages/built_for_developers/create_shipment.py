import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

shipment = client.shipment.create(
    to_address={"id": "adr_..."},
    from_address={"id": "adr_..."},
    parcel={
        "predefined_package": "Parcel",
        "weight": 32.8,
    },
)

client.shipment.buy(
    shipment.id,
    rate=shipment.lowest_rate(),
)
