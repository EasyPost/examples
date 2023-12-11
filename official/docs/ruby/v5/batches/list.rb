require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

batches = client.batch.all(
  page_size: 5,
)

puts batches
