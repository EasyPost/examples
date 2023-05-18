require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

success = client.referral_customer.delete('primary')

puts success
