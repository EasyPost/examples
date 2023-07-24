to_address = EasyPost::Address.create(...)
from_address = EasyPost::Address.create(...)
parcel = EasyPost::Parcel.create(
  predefined_package: "Parcel",
  weight: 28
)

shipment = EasyPost::Shipment.create(
  to_address: to_address,
  from_address: from_address,
  parcel: parcel
)

shipment.buy(shipment.lowest_rate)
