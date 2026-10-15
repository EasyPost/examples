require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

pickup = EasyPost::Pickup.retrieve('pickup_...')

pickup.cancel

puts pickup
