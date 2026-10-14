require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

refunds = EasyPost::Refund.all(
  page_size: 5,
)

puts refunds
