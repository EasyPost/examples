require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

tracker = client.tracker.create(
  tracking_code: 'EZ1000000001',
  carrier: 'USPS',
)

puts tracker
