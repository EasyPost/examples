require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

address = client.address.retrieve('adr_...')

puts address
