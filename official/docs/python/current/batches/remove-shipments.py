import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

batch = client.batch.remove_shipments(
    "batch_...",
    shipments=[
        {
            "id": "shp_...",
        }
    ],
)

print(batch)
