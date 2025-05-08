require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

message = client.referral_customer.update_email(
  'user_...',
  'new_email@example.com',
)

puts message
