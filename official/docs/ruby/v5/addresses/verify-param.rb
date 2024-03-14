require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

address = client.address.create(
  verify: true,
  street1: '417 Montgomery Street',
  street2: '5',
  city: 'SF',
  state: 'CA',
  zip: '94104',
  country: 'US',
  company: 'EasyPost',
  phone: '415-123-4567',
)

puts address
