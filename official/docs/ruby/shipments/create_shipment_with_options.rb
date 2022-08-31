require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

shipment = EasyPost::Shipment.create(
  {
    to_address: {
      id: 'adr_...',
    },
    from_address: {
      id: 'adr_...',
    },
    parcel: {
      id: 'prcl_...',
    },
    options: {
      print_custom_1: 'Custom label message',
    },
  },
)

puts shipment
