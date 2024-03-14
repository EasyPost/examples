require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

success = EasyPost::Billing.fund('2000', 'primary')

puts success
