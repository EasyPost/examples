import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

batch = client.batch.create(
    shipments=[
        {"id": "shp_..."},
        {"id": "shp_..."},
    ],
)

print(batch)
