require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

scan_form = client.scan_form.create(
  shipments: [
    {
      id: 'shp_...',
    },
    {
      id: 'shp_...',
    },
  ],
)

puts scan_form
