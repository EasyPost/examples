require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

credit_card = client.referral_customer.add_credit_card(
  'REFERRAL_USER_API_KEY',
  '0123456789101234',
  '01',
  '2025',
  '111',
)

puts credit_card
