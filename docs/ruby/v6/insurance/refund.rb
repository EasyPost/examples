require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

insurance = client.insurance.refund('ins_...')

puts insurance
