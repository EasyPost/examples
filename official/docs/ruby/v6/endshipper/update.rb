require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

end_shipper = client.end_shipper.update(
  'es_...',
  {
    name: 'New Name',
    street1: '388 Townsend St',
    street2: 'Apt 20',
    city: 'San Francisco',
    state: 'CA',
    zip: '94107',
    country: 'US',
    email: 'test@example.com',
    phone: '5555555555',
  },
)

puts end_shipper
