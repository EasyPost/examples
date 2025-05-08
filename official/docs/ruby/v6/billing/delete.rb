require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

client.referral_customer.delete('primary')
