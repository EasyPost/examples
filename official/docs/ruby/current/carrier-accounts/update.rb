require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

retreived_carrier_account = client.carrier_account.retrieve('ca_...')

carrier_account = client.carrier_account.update(
  retreived_carrier_account.id,
  description: 'FL Location DHL eCommerce Solutions Account',
)

puts carrier_account
