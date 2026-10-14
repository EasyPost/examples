import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

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

shipment = client.shipment.generate_form("shp_...", form_type, form_options)

print(shipment)
