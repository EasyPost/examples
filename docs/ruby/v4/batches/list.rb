require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

batches = EasyPost::Batch.all(
  page_size: 5,
)

puts batches
