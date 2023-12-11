require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

refunds = client.refund.all(
  page_size: 5,
)

puts refunds
