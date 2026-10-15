require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

referral_user = client.referral_customer.create(
  name: 'test user',
  email: 'email@example.com',
  phone: '8888888888',
)

puts referral_user
