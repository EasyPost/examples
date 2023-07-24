# Create To and From Addresses
from_address = EasyPost::Address.create(...)
to_address = EasyPost::Address.create(...)

# Create Shipment and Get Rates
shipment = EasyPost::Shipment.create(
  from_address: from_address,
  to_address: to_address,
  parcel: {
    predefined_package: 'Parcel',
    weight: 32.8
  }
)

# Buy Shipping Label
shipment.buy(rate: shipment.lowest_rate())
