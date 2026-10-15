require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

event = client.event.retrieve('evt_...')

puts event
