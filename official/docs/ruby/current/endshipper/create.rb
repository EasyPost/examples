require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

end_shipper = client.end_shipper.create(
  name: 'FOO BAR',
  company: 'BAZ',
  street1: '164 TOWNSEND STREET UNIT 1',
  street2: 'UNIT 1',
  city: 'SAN FRANCISCO',
  state: 'CA',
  zip: '94107',
  country: 'US',
  phone: '555-555-5555',
  email: 'FOO@EXAMPLE.COM',
)

puts end_shipper
