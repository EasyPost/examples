require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

shipment = EasyPost::Shipment.retrieve("shp_...")

shipment.buy(
  rate: 'rate...', 
  insurance: nil, 
  with_carbon_offset: false, 
  end_shipper_id: 'es_...'
)

puts shipment
