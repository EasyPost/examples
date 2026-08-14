# shellcheck disable=SC2016
curl -X POST https://api.easypost.com/readydocs/packslip \
  -u "EASYPOST_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{
    "pack_slip_data": {
      "pack_slip": {
        "project": "hsn_8x11",
        "output_type": "S3",
        "order": {
          "ship_to": {
            "address": {
              "name": "Dr. Steve Brule",
              "company": "EasyPost",
              "street1": "417 Montgomery Street",
              "street2": "5th Floor",
              "city": "San Francisco",
              "state": "CA",
              "zip": "94104",
              "country": "US",
              "phone": "4155559999",
              "email": "dr_steve_brule@example.com"
            }
          },
          "ship_from": {
            "address": {
              "name": "EasyPost",
              "company": "EasyPost",
              "street1": "417 Montgomery Street",
              "street2": "5th Floor",
              "city": "San Francisco",
              "state": "CA",
              "zip": "94104",
              "country": "US",
              "phone": "4155559999",
              "email": "support@example.com"
            }
          },
          "bill_to": {
            "address": {
              "name": "Dr. Steve Brule",
              "street1": "179 N Harbor Dr",
              "city": "Redondo Beach",
              "state": "CA",
              "zip": "90277",
              "country": "US",
              "phone": "8575551212",
              "email": "dr_steve_brule@example.com"
            }
          },
          "customer_service": {
            "phone": "4155559999",
            "email": "support@example.com",
            "website": "https://www.example.com"
          },
          "customer_id": "customer_123",
          "customer_order": "order_123",
          "order_number": "123456",
          "po_number": "PO-123456",
          "invoice_number": "INV-123456",
          "warehouse_id": "warehouse_123",
          "ship_date": "08/11/2026",
          "order_date": "08/10/2026",
          "delivery_date": "08/14/2026",
          "ship_method": "Ground",
          "pay_method": "Credit Card",
          "order_message": "Thank you for your order.",
          "sub_total": "$25.00",
          "sales_tax": "$2.00",
          "shipping_handling": "$5.00",
          "credit": "$0.00",
          "total": "$32.00",
          "currency_uom": "$",
          "sales_person": "Steve Brule",
          "order_lines": {
            "line": [
              {
                "item_id": "item_123",
                "upc": "012345678905",
                "merchant_sku": "SKU-123",
                "customer_part_number": "PART-123",
                "description": "T-shirt",
                "item_style": "Blue / Medium",
                "qty": {
                  "ord": 2,
                  "ship": 2,
                  "bo": 0,
                  "uom": "each"
                },
                "unit_price": "$12.50",
                "total_price": "$25.00",
                "gift_message": "Happy Birthday!"
              }
            ]
          }
        },
        "shipping_label": {
          "data": "test",
          "format": "PNG",
          "encoding": "base64"
        },
        "print_commands": {
          "print": {
            "type": "text",
            "encoding": "base64",
            "encoding_character_set": "UTF-8",
            "data": "test",
            "size": "4x6",
            "format": "ZPL"
          }
        },
        "image": {
          "char_set": "ISO-8859-1",
          "image_data": "/9j/4AAQS.......QhCA/",
          "image_format": "JPEG"
        }
      }
    }
  }'
