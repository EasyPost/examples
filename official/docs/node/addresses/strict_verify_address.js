const Easypost = require('@easypost/api');
const api = new Easypost('EASYPOST_API_KEY');

const address = new api.Address({
  verify_strict: true,
  street1: '417 MONTGOMERY ST',
  street2: 'FLOOR 5',
  city: 'SAN FRANCISCO',
  state: 'CA',
  zip: '94104',
  country: 'US',
  company: 'EasyPost',
  phone: '415-123-4567',
});

address.save().then(console.log);
