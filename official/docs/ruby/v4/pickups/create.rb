require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

pickup = EasyPost::Pickup.create(
  reference: 'my-first-pickup',
  min_datetime: '2022-10-01 10:30:00',
  max_datetime: '2022-10-02 10:30:00',
  shipment: {
    id: 'shp_...',
  },
  address: {
    id: 'adr_...',
  },
  is_account_address: false,
  instructions: 'Special pickup instructions',
)

puts pickup
