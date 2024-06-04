require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

retrieved_shipment = client.shipment.retrieve('shp_...')

shipment = client.shipment.label(retrieved_shipment.id, file_format: 'ZPL')

puts shipment
