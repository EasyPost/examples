require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

shipment = client.shipment.label('shp_...', file_format: 'ZPL')

puts shipment
