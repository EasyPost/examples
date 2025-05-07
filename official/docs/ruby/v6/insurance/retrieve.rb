require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

insurance = client.insurance.retrieve('ins_...')

puts insurance
