require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

payment_method = EasyPost::Beta::Referral.add_payment_method(
  'cus_...',
  'card_...',
  'primary',
)

puts payment_method
