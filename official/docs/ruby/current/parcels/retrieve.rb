require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

parcel = client.parcel.retrieve('prcl_...')

puts parcel
