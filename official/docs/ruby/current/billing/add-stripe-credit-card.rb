require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

payment_method = client.referral_customer.add_credit_card_from_stripe(
  'REFERRAL_USER_API_KEY',
  'seti_...',
  'primary',
)

puts payment_method
