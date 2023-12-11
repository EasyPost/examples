require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

referral_users = client.referral_customer.all(
  page_size: 5,
)

puts referral_users
