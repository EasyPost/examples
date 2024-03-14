require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

payment_method = EasyPost::Beta::Referral.add_payment_method(
  'cus_...',
  'ba_...',
  'primary',
)

puts payment_method
