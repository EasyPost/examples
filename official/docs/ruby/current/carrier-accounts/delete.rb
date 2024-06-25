require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

client.carrier_account.delete('ca_...')
