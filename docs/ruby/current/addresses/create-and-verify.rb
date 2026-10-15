require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

address = client.address.create_and_verify(
  street1: '000 unknown street',
  city: 'Not A City',
  state: 'ZZ',
  zip: '00001',
  country: 'US',
  email: 'test@example.com',
  phone: '5555555555',
)

puts address
