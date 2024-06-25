require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

pickup = client.pickup.cancel('pickup_...')

puts pickup
