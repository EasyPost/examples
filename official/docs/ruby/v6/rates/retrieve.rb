require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

rate = client.rate.retrieve('rate...')

puts rate
