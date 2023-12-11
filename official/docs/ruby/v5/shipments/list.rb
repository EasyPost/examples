require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

shipments = client.shipment.all(
  page_size: 5,
)

puts shipments
