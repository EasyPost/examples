require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

shipment = client.shipment.create(
  to_address: to_address,
  from_address: from_address,
  parcel: {
    predefined_package: 'Parcel',
    weight: 28,
  },
)

client.shipment.buy(shipment.id, shipment.lowest_rate)
