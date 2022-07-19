require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

batches = EasyPost::Batch.all(
  page_size: 5,
)

batch_array = batches.batches

puts batch_array
