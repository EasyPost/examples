const Easypost = require('@easypost/api');

const api = new Easypost('EASYPOST_API_KEY');

const address = new api.Address({
  street1: '417 montgomery streat',
  city: 'SAN FRANCISCO',
  state: 'CA',
  zip: '94104',
  country: 'US',
  company: 'EasyPost',
  phone: '415-123-4567',
});

address.save().then((createdAddress) => {
  createdAddress.verifyAddress().then(console.log);
});
