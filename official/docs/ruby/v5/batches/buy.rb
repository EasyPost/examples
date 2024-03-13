require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

batch = client.batch.buy('batch_...')

puts batch
