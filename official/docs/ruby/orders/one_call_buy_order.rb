require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

order = EasyPost::Order.create(
  carrier_accounts: ['ca_...'],
  service: 'NextDayAir',
  to_address: to_address,
  from_address: from_address,
  shipments: [
    { parcel: { predefined_package: 'FedExBox', weight: 10.2 } },
    { parcel: { predefined_package: 'FedExBox', weight: 17.5 } },
  ],
)

puts order
