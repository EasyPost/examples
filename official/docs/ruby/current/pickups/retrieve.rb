require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

pickup = client.pickup.retrieve('pickup_...')

puts pickup
