require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

address = client.address.verify('adr_...')

puts address
