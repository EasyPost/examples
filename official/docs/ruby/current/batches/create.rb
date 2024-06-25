require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

batch = client.batch.create(
  'batch_...',
  shipments: [
    { id: 'shp_...' },
    { id: 'shp_...' },
  ],
)

puts batch
