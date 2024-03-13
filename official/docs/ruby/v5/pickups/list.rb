require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

pickups = client.pickup.all(
  page_size: 5,
)

puts pickups
