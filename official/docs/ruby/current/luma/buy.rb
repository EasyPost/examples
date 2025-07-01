require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

shipment = EasyPost::Shipment.retrieve('shp_...')

shipment = shipment.luma(
  ruleset_name: 'ruleset_name',
  planned_ship_date: '2025-07-01',
  deliver_by_date: '2025-07-03',
)

puts shipment
