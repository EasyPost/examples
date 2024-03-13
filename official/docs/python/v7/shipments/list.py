import easypost

easypost.api_key = "EASYPOST_API_KEY"

shipments = easypost.Shipment.all(
    page_size=5,
)

print(shipments)
