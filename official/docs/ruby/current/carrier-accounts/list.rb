require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

carrier_accounts = client.carrier_account.all

puts carrier_accounts
