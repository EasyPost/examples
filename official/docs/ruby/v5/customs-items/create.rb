require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

customs_item = client.customs_item.create(
  description: 'T-shirt',
  quantity: 1,
  weight: 5,
  value: 10,
  hs_tariff_number: '123456',
  origin_country: 'us',
)

puts customs_item
