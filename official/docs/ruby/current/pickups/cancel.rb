require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

retrieved_pickup = client.pickup.retrieve('pickup_...')

pickup = client.pickup.cancel(retrieved_pickup.id)

puts pickup
