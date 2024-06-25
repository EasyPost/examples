require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

retrieved_shipment = client.shipment.retrieve()

shipment = client.shipment.buy(
  retrieved_shipment.id,
  rate: retrieved_shipment.lowest_rate,
  insurance: '244.99',
)

puts shipment
