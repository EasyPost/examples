require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

batch = client.batch.buy('batch_...')

puts batch
