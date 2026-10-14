require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

results = client.smart_rate.recommend_ship_date(
  from_zip: '10001',
  to_zip: '10002',
  desired_delivery_date: '2024-07-18',
  carriers: ['ups'],
)

puts results
