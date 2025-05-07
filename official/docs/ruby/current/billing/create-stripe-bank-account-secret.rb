require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

response = client.beta_referral_customer.create_bank_account_client_secret

puts response
