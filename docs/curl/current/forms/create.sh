# type always required
# all other elements differ based on form type
curl -X POST https://api.easypost.com/v2/shipments/shp_.../forms \
  -u "EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
    "form": {
        "type": "return_packing_slip",
        "barcode": "RMA12345678900",
        "line_items": [
        {
            "product": {
                "title": "Square Reader",
                "barcode": "855658003251"
            },
            "units": 8
        }
      ]
    }
  }'
