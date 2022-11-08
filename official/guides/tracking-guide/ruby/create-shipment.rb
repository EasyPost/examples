require 'easypost'
EasyPost.api_key = '<YOUR_TEST/PRODUCTION_API_KEY>'

shipment = EasyPost::Shipment.create(
  {
    to_address: {
      name: 'George Costanza',
      company: 'Vandelay Industries',
      street1: '1 E 161st St.',
      city: 'Bronx',
      state: 'NY',
      zip: '10451',
    },
    from_address: {
      company: 'EasyPost',
      street1: '417 Montgomery Street',
      street2: '5th Floor',
      city: 'San Francisco',
      state: 'CA',
      zip: '94104',
      phone: '415-528-7555',
    },
    parcel: {
      length: 9,
      width: 6,
      height: 2,
      weight: 10,
    },
  },
)

shipment.buy(
  rate: shipment.lowest_rate,
)
