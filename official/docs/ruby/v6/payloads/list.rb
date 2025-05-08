require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

payloads = client.event.retrieve_all_payloads('evt_...')

puts payloads
