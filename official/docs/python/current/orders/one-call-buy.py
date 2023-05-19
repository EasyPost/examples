import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

order = client.order.create(
    carrier_accounts=["ca_..."],
    service="NextDayAir",
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
