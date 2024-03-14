require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

address = client.address.create(
  verify_strict: true,
  street1: '417 MONTGOMERY ST',
  street2: 'FLOOR 5',
  city: 'SAN FRANCISCO',
  state: 'CA',
  zip: '94104',
  country: 'US',
  company: 'EasyPost',
  phone: '415-123-4567',
)

puts address
