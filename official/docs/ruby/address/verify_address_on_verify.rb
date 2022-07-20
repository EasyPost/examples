require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

address = EasyPost::Address.create(
  verify: ['delivery'],
  street1: '417 montgomery streat',
  street2: 'FL 5',
  city: 'SAN FRANCISCO',
  state: 'CA',
  zip: '94104',
  country: 'US',
  company: 'EasyPost',
  phone: '415-123-4567',
)

puts address
