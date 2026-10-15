require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

pickups = EasyPost::Pickup.all(
  page_size: 5,
)

puts pickups
