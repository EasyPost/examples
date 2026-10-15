require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

rates = client.shipment.recommend_ship_date(
  'shp_...',
  'YYYY-MM-DD',
)

puts rates
