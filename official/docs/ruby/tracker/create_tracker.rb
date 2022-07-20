require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

tracker = EasyPost::Tracker.create(
  {
    tracking_code: '9400110898825022579493',
    carrier: 'USPS',
  },
)

puts tracker
