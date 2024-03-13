require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

referral_users = EasyPost::Referral.all(
  page_size: 5,
)

puts referral_users
