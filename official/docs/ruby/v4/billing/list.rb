require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

payment_methods = EasyPost::Billing.retrieve_payment_methods

puts payment_methods
