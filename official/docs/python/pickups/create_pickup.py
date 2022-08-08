import easypost


easypost.api_key = "EASYPOST_API_KEY"

pickup = easypost.Pickup.create(
    address={"id": "adr_..."},
    shipment={"id": "shp_..."},
    reference="my-first-pickup",
    min_datetime="2014-10-21 10:30:00",
    max_datetime="2014-10-22 10:30:00",
    is_account_address=False,
    instructions="Special pickup instructions",
)

print(pickup)
