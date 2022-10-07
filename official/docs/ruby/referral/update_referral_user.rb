require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

referral_users = EasyPost::Referral.all(
  page_size: 5,
)

updated_user = EasyPost::Referral.update_email(
  'email2@example.com',
  referral_users[0].id,
)

puts updated_user
