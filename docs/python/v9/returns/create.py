import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

shipment = client.shipment.create(
    to_address={"id": "adr_..."},
    from_address={"id": "adr_..."},
    parcel={"id": "prcl_..."},
    is_return=True,
)

print(shipment)
