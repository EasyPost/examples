require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

retrieved_batch = client.batch.retrieve('batch_...')

batch = client.batch.create_scan_form(retrieved_batch.id)

puts batch
