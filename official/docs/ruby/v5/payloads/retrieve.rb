require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

payload = client.event.retrieve_payload('evt_...', 'payload_...')

puts payload
