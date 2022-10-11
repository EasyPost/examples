require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

updated_user = EasyPost::Referral.update_email(
  'new_email@example.com',
  'user_...',
)

puts updated_user
