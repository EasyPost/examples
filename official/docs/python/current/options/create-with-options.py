import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

shipment = client.shipment.create(
    to_address={"id": "adr_..."},
    from_address={"id": "adr_..."},
    parcel={"id": "prcl_..."},
    options={"print_custom_1": "Custom label message"},
)

print(shipment)
