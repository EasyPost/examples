require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

message = client.referral_customer.update_email(
  'new_email@example.com',
  'user_...',
)

puts message
