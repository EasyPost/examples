require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

purchased_shipment = EasyPost::Shipment.retrieve('shp_...')
purchased_shipment.insure(amount: 100)

puts purchased_shipment
