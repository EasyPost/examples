require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

params = {
    from_zip: '10001',
    to_zip: '10002',
    planned_ship_date: '2024-07-18',
    carriers: ['ups'],
  }

results = client.smart_rate.estimate_delivery_date(params)

puts results
