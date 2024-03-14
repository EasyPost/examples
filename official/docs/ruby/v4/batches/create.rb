require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

batch = EasyPost::Batch.create(
  shipments: [
    { id: 'shp_...' },
    { id: 'shp_...' },
  ],
)

puts batch
