require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

retrieved_batch = client.batch.retrieve('batch_...')

batch = client.batch.remove_shipments(
  retrieved_batch,
  shipments: [
    { id: 'shp_...' },
  ],
)

puts batch
