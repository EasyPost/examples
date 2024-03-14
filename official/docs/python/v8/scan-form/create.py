import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

scan_form = client.scan_form.create(
    shipments=[
        {"id": "shp_..."},
        {"id": "shp_..."},
    ]
)

print(scan_form)
