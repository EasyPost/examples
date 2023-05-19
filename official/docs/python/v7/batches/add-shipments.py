import os

import easypost


easypost.api_key = os.getenv("EASYPOST_API_KEY")

batch = easypost.Batch.retrieve("batch_...")

batch.add_shipments(
    shipments=[
        {"id": "shp_..."},
        {"id": "shp_..."},
    ]
)

print(batch)
