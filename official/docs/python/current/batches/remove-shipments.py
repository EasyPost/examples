import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

batch = client.batch.retrieve("batch_...")

batch_without_shipments = batch.remove_shipments(
    batch.id,
    shipments=[
        {
            "id": "shp_...",
        }
    ],
)

print(batch_without_shipments)
