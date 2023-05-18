require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

retrieved_shipment = client.shipment.retrieve('shp_...')
shipment = client.shipment.buy(retrieved_shipment.id, shipment.lowest_rate, true)

puts shipment
