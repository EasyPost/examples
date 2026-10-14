require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

payloads = EasyPost::Event.retrieve_all_payloads('evt_...')

puts payloads
