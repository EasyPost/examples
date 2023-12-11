require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

carrier_account = client.carrier_account.retrieve('ca_...')

puts carrier_account
