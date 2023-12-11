require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

event = client.event.retrieve('evt_...')

puts event
