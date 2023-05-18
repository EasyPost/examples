require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

retrieved_carrier_account = client.carrier_account.retrieve('ca_...')

success = client.carrier_account.delete(retrieved_carrier_account.id)

puts success
