require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

carrier_types = client.carrier_account.types

puts carrier_types
