import easypost
easypost.api_key = "EASYPOST_API_KEY"

shipment = easypost.Shipment.create(
  to_address={
    "name": 'Dr. Steve Brule',
    "street1": '179 N Harbor Dr',
    "city": 'Redondo Beach',
    "state": 'CA',
    "zip": '90277',
    "country": 'US',
    "phone": '4153334444',
    "email": 'dr_steve_brule@gmail.com'
  },
  from_address={
    "name": 'EasyPost',
    "street1": '417 Montgomery Street',
    "street2": '5th Floor',
    "city": 'San Francisco',
    "state": 'CA',
    "zip": '94104',
    "country": 'US',
    "phone": '4153334444',
    "email": 'support@easypost.com'
  },
  parcel={
    "length": 20.2,
    "width": 10.9,
    "height": 5,
    "weight": 65.9
  },
  customs_info={
    "id": "cstinfo_..."
  },
  tax_identifiers=[{
    "entity": "SENDER",
    "tax_id": "GB123456789",
    "tax_id_type": "IOSS",
    "issuing_country": "GB",
  }]
)

print(shipment)
