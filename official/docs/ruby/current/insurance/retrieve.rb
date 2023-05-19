require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

insurance = client.insurance.retrieve('ins_...')

puts insurance
