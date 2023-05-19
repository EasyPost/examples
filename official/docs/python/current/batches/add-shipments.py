import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

batch = client.batch.retrieve("batch_...")

batch_with_shipments = client.batch.add_shipments(
    client.id,
    shipments=[
        {"id": "shp_..."},
        {"id": "shp_..."},
    ],
)

print(batch_with_shipments)
