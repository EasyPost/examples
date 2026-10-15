import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

batch = client.batch.retrieve("batch_...")

batch_with_shipments = client.batch.add_shipments(
    batch.id,
    shipments=[
        {"id": "shp_..."},
        {"id": "shp_..."},
    ],
)

print(batch_with_shipments)
