import os

import easypost


easypost.api_key = os.getenv("EASYPOST_API_KEY")

shipment = easypost.Shipment.retrieve("shp_...")

form_type = "return_packing_slip"
form_options = {
    "barcode": "RMA12345678900",
    "line_items": [
        {
            "product": {
                "title": "Square Reader",
                "barcode": "855658003251",
            },
            "units": 8,
        },
    ],
}

shipment.generate_form(form_type, form_options)

print(shipment)
