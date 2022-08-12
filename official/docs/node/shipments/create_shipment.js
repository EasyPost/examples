const Easypost = require('@easypost/api');
const api = new Easypost('EASYPOST_API_KEY');

const shipment = new api.Shipment({
  to_address: {
    name: 'Dr. Steve Brule',
    street1: '179 N Harbor Dr',
    city: 'Redondo Beach',
    state: 'CA',
    zip: '90277',
    country: 'US',
    email: 'dr_steve_brule@gmail.com',
    phone: '4155559999',
  },
  from_address: {
    street1: '417 montgomery street',
    street2: 'FL 5',
    city: 'San Francisco',
    state: 'CA',
    zip: '94104',
    country: 'US',
    company: 'EasyPost',
    phone: '415-123-4567',
  },
  parcel: {
    length: 20.2,
    width: 10.9,
    height: 5,
    weight: 65.9,
  },
  customs_info: { id: 'cstinfo_...' },
});

shipment.save().then(console.log);

// or create by using IDs

const shipment2 = new api.Shipment({
  to_address: { id: 'adr_...' },
  from_address: { id: 'adr_...' },
  parcel: { id: 'prcl_...' },
  customs_info: { id: 'cstinfo_...' },
});

shipment2.save().then(console.log);
