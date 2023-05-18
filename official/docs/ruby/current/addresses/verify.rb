require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

address = client.address.create(
  street1: '417 MONTGOMERY ST',
  street2: 'FLOOR 5',
  city: 'SAN FRANCISCO',
  state: 'CA',
  zip: '94104',
  country: 'US',
  company: 'EasyPost',
  phone: '415-123-4567',
)

address.verify

puts address
