import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

batch = client.batch.add_shipments(
    "batch_...",
    shipments=[
        {"id": "shp_..."},
        {"id": "shp_..."},
    ],
)

print(batch)
