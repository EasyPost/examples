require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

retrieved_batch = client.batch.retrieve('batch_...')

label_batch = client.batch.label(
  retrieved_batch.id,
  file_format: 'PDF',
)

puts label_batch
