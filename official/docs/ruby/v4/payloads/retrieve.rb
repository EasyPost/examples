require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

payload = EasyPost::Event.retrieve_payload('evt_...', 'payload_...')

puts payload
