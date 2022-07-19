require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

shipments = EasyPost::Shipment.all(
  page_size: 2,
  start_datetime: '2016-01-02T08:50:00Z',
)

puts shipments
