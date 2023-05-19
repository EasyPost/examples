require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

shipment = client.shipment.retrieve('shp_...')

puts shipment
