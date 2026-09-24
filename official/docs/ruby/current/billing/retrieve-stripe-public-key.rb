require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

response = client.beta_referral_customer.retrieve_easypost_stripe_api_key

puts response
