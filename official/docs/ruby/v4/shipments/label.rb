require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

shipment = EasyPost::Shipment.retrieve('shp_...')

shipment.label(file_format: 'ZPL')

puts shipment
