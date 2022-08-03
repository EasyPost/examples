import easypost
easypost.api_key = "EASYPOST_API_KEY"

order = easypost.Order.create(
    to_address={
        "id": "adr_..."
    },
    from_address={
        "id": "adr_..."
    },
    shipments=[
        {
            "parcel": {
                "predefined_package": "FedExBox",
                "weight": 10.2
            }
        },
        {
            "parcel": {
                "predefined_package": "FedExBox",
                "weight": 17.5
            }
        }
    ]
)

print(order)
