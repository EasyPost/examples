require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

parcel = client.parcel.retrieve('prcl_...')

puts parcel
