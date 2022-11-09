const Easypost = require('@easypost/api');
const api = new Easypost('<YOUR_TEST/PRODUCTION_API_KEY>');

const shipment = new api.Shipment({
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
});

shipment.save().then(() => {
  shipment.buy(shipment.lowestRate());
});
