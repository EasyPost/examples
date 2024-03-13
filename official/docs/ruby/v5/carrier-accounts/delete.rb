require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

retrieved_carrier_account = client.carrier_account.retrieve('ca_...')

client.carrier_account.delete(retrieved_carrier_account.id)
