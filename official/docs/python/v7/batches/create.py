import os

import easypost


easypost.api_key = os.getenv("EASYPOST_API_KEY")

batch = easypost.Batch.create(
    shipments=[
        {"id": "shp_..."},
        {"id": "shp_..."},
    ],
)

print(batch)
