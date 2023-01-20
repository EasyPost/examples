require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

refunds = EasyPost::Refund.create(
  carrier: 'USPS',
  tracking_codes: ['XXXXX'],
)

puts refunds
