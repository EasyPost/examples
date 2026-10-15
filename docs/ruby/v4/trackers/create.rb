require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

tracker = EasyPost::Tracker.create(
  tracking_code: 'EZ1000000001',
  carrier: 'USPS',
)

puts tracker
