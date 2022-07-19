require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

shipment = EasyPost::Shipment.retrieve('shp_...')
shipment.get_smartrates

puts shipment
