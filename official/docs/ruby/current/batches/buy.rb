require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

created_batch = client.batch.create(
  shipments: [
    {
      from_address: { id: 'adr_...' },
      to_address: { id: 'adr_...' },
      parcel: { id: 'prcl_...' },
      service: 'First',
      carrier: 'USPS',
      carrier_accounts: ['ca_...'],
    },
  ],
)

batch = client.batch.buy(created_batch.id)

puts batch
