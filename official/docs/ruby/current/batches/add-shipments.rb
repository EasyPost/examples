require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

retrieved_batch = client.batch.retrieve('batch_...')

batch = client.batch.add_shipments(
  retrieved_batch.id,
  shipments: [
    { id: 'shp_...' },
    { id: 'shp_...' },
  ],
)

puts batch
