require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

pickup = EasyPost::Pickup.retrieve('pickup_...')

pickup.buy(carrier: 'UPS', service: 'Same-Day Pickup')

puts pickup
