require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

retrieved_pickup = client.pickup.retrieve('pickup_...')

pickup = client.pickup.buy(retrieved_pickup.id, carrier: 'UPS', service: 'Same-Day Pickup')

puts pickup
