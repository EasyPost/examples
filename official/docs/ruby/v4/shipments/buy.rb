require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

shipment = EasyPost::Shipment.retrieve('shp_...')

shipment.buy(
  rate: shipment.lowest_rate,
  insurance: '244.99',
)

puts shipment
