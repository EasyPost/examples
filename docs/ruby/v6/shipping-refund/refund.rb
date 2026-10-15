require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

shipment = client.shipment.refund('shp_...')

puts shipment
