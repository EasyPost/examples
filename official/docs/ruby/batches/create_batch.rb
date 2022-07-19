require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

batch = EasyPost::Batch.create(
  shipments: [{ id: 'shp_...' }],
)

puts batch
