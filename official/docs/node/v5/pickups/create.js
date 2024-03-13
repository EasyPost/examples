const Easypost = require('@easypost/api');

const api = new Easypost('EASYPOST_API_KEY');

const pickup = new api.Pickup({
  address: { id: 'adr_...' },
  shipment: { id: 'shp_...' },
  reference: 'my-first-pickup',
  min_datetime: '2022-10-01 10:30:00',
  max_datetime: '2022-10-02 10:30:00',
  is_account_address: false,
  instructions: 'Special pickup instructions',
});

pickup.save().then(console.log);
