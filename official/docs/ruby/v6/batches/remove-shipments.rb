require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

batch = client.batch.remove_shipments(
  'batch_...',
  shipments: [
    { id: 'shp_...' },
  ],
)

puts batch
