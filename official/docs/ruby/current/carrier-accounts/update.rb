require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

carrier_account = client.carrier_account.update(
  'ca_...',
  description: 'FL Location DHL eCommerce Solutions Account',
)

puts carrier_account
