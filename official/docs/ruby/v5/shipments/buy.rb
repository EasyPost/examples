require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

retrieved_shipment = client.shipment.retrieve('shp_...')

shipment = client.shipment.buy(
  retrieved_shipment.id,
  rate: shipment.lowest_rate,
  insurance: '244.99',
)

puts shipment
