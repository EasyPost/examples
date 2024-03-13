require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

refunds = client.refund.create(
  carrier: 'USPS',
  tracking_codes: ['EZ1000000001'],
)

puts refunds
