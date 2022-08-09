require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

insurance = EasyPost::Insurance.create(
  {
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
  },
)

puts insurance
