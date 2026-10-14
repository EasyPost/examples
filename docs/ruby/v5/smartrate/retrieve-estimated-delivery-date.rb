require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

retrieved_shipment = client.shipment.retrieve('shp_...')

estimated_delivery_dates = client.shipment.retrieve_estimated_delivery_date(
  retrieved_shipment.id,
  'YYYY-MM-DD',
)

puts estimated_delivery_dates
