shipment = easypost.Shipment.create(
  to_address={
    'name': 'Tim Canterbury',
    'company': 'Wernham Hogg',
    'street1': '118 Clippenham Lane',
    'city': 'Slough',
    'country': 'GB',
    'zip': 'SL15BE'
  },
  from_address={
    'company': 'EasyPost',
    'street1': '417 Montgomery Street',
    'street2': '5th Floor',
    'city': 'San Francisco',
    'state': 'CA',
    'zip': '94104',
    'phone': '415-528-7555'
  },
  parcel={
    'length': 9,
    'width': 6,
    'height': 3,
    'weight': 20
  },
  customs_info = customs_info
)
