require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

purchased_shipment = EasyPost::Shipment.retrieve('shp_...')
purchased_shipment.insure(amount: 888.50)

puts purchased_shipment
