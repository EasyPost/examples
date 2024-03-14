require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

shipments = EasyPost::Shipment.all(
  page_size: 5,
)

puts shipments
