require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

payload = EasyPost::Event.retrieve_payload('evt_...', 'payload_...')

puts payload
