require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

pickup = client.pickup.buy('pickup_...', carrier: 'UPS', service: 'Same-Day Pickup')

puts pickup
