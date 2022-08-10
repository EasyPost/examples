const Easypost = require('@easypost/api');
const api = new Easypost('EASYPOST_API_KEY');

api.Address.createAndVerify({
  street1: '417 montgomery street',
  street2: 'FL 5',
  city: 'San Francisco',
  state: 'CA',
  zip: '94104',
  country: 'US',
  company: 'EasyPost',
  phone: '415-123-4567',
}).then((verifiedAddress) => {
  console.log(verifiedAddress);
});
