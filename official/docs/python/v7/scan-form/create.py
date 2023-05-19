import os

import easypost


easypost.api_key = os.getenv("EASYPOST_API_KEY")

scan_form = easypost.ScanForm.create(
    shipments=[
        {"id": "shp_..."},
        {"id": "shp_..."},
    ]
)

print(scan_form)
