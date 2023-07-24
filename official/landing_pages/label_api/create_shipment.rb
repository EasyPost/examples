require 'easypost'

EasyPost.api_key = "<YOUR_TEST/PRODUCTION_API_KEY>"

to_address = EasyPost::Address.create(...)
from_address = EasyPost::Address.create(...)
parcel = EasyPost::Parcel.create(...)

shipment = EasyPost::Shipment.create(
  to_address: to_address,
  from_address: from_address,
  parcel: parcel,
  options: { label_format: 'ZPL' }
)
