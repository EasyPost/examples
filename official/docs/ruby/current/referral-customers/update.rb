require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

EasyPost::Referral.update_email(
  'new_email@example.com',
  'user_...',
)
