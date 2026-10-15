require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

retrieved_shipment = client.shipment.retrieve('shp_...')
shipment = client.shipment.insure(retrieved_shipment.id, amount: 100)

puts shipment
