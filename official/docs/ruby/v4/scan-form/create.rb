require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

scan_form = EasyPost::ScanForm.create(
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
