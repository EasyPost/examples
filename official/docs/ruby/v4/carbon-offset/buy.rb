require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

shipment = EasyPost::Shipment.retrieve('shp_...')
shipment.buy(shipment.lowest_rate, true)

puts shipment
