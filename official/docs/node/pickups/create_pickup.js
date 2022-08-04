const Easypost = require('@easypost/api');
const api = new Easypost('EASYPOST_API_KEY');

const address = 'adr_...';
const shipment = 'shp_...';

const pickup = new api.Pickup({
  address,
  shipment,
  reference: 'my-first-pickup',
  min_datetime: '2014-10-21 10:30:00',
  max_datetime: '2014-10-22 10:30:00',
  is_account_address: false,
  instructions: 'Special pickup instructions',
});

pickup.save().then(console.log);
