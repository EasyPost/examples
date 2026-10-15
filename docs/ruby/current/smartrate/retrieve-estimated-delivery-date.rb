require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

estimated_delivery_dates = client.shipment.retrieve_estimated_delivery_date(
  'shp_...',
  'YYYY-MM-DD',
)

puts estimated_delivery_dates
