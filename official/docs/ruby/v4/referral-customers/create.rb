require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

referral_user = EasyPost::Referral.create(
  name: 'test user',
  email: 'email@example.com',
  phone: '8888888888',
)

puts referral_user
