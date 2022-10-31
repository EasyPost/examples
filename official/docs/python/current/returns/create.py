import os

import easypost


easypost.api_key = os.getenv("EASYPOST_API_KEY")

shipment = easypost.Shipment.create(
    to_address={"id": "adr_..."},
    from_address={"id": "adr_..."},
    parcel={"id": "prcl_..."},
    is_return=True,
)

print(shipment)
