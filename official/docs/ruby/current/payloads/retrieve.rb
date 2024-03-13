require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

payload = client.event.retrieve_payload('evt_...', 'payload_...')

puts payload
