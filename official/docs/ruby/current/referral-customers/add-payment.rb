require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

payment_method = EasyPost::Beta::Referral.add_payment_method(
    'cus_123',
    'ba_123',
  )

puts payment_method
