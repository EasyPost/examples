require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

batch = client.batch.label(
  'batch_...',
  file_format: 'PDF',
)

puts batch
