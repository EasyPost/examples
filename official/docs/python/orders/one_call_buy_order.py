import easypost


easypost.api_key = "EASYPOST_API_KEY"

order = easypost.Order.create(
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
