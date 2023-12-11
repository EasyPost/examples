require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

parcel = client.parcel.create(
  length: 20.2,
  width: 10.9,
  height: 5,
  weight: 65.9,
)

puts parcel
