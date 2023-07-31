import easypost
import os

easypost.api_key = os.getenv("EASYPOST_API_KEY")

batch = easypost.Batch.retrieve("batch_...")

batch.remove_shipments(
    shipments=[
        {
            "id": "shp_...",
        }
    ]
)

print(batch)
