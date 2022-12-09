require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

referral_user_api_key = ENV['REFERRAL_USER_API_KEY']

credit_card = EasyPost::Referral.add_credit_card(
  referral_user_api_key,
  '0123456789101234',
  '01',
  '2025',
  '111',
)

puts credit_card
