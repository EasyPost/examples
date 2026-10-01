require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

api_key = client.api_key.enable('ak_...')

puts api_key
