import os

import easypost


easypost.api_key = os.getenv("EASYPOST_API_KEY")

form = easypost.Shipment.create(
    type="return_packing_slip",
    barcode="RMA12345678900",
    line_items={
        "product": {
            "title": "Square Reader",
            "barcode": "855658003251",
        },
        "barcode": 8,
    },
)

print(form)
