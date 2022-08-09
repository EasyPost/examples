const Easypost = require('@easypost/api');
const api = new Easypost('EASYPOST_API_KEY');

const address = new api.Address({
  verify: true,
  street1: '417 Montgomery Street',
  street2: '5',
  city: 'SF',
  state: 'CA',
  zip: '94104',
  country: 'US',
  company: 'EasyPost',
  phone: '415-123-4567',
});

console.log(address);
