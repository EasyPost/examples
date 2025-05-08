import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

batch = client.batch.create(
    shipments=[
        {"id": "shp_..."},
        {"id": "shp_..."},
    ],
)

print(batch)
