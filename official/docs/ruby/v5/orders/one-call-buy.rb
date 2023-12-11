require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

order = client.order.create(
  to_address: {
    id: 'adr_...',
  },
  from_address: {
    id: 'adr_...',
  },
  shipments: [
    {
      parcel: {
        weight: 10.2,
      },
    },
    {
      parcel: {
        predefined_package: 'FedExBox',
        weight: 17.5,
      },
    },
  ],
  service: 'NextDayAir',
  carrier_accounts: ['ca_...'],
)

puts order
