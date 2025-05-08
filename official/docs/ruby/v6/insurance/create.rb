require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

insurance = client.insurance.create(
  to_address: {
    id: 'adr_...',
  },
  from_address: {
    id: 'adr_...',
  },
  tracking_code: '9400110898825022579493',
  carrier: 'USPS',
  reference: 'insuranceRef1',
  amount: '100.00',
)

puts insurance
