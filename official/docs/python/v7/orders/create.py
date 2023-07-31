import easypost
import os

easypost.api_key = os.getenv("EASYPOST_API_KEY")

order = easypost.Order.create(
    to_address={"id": "adr_..."},
    from_address={"id": "adr_..."},
    shipments=[
        {
            "parcel": {
                "predefined_package": "FedExBox",
                "weight": 10.2,
            }
        },
        {
            "parcel": {
                "predefined_package": "FedExBox",
                "weight": 17.5,
            }
        },
    ],
)

print(order)
