require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

addresses = client.address.all(
  page_size: 5,
)

puts addresses
