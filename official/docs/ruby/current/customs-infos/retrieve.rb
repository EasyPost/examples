require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

customs_info = client.customs_info.retrieve('cstinfo_...')

puts customs_info
