const Easypost = require('@easypost/api');
const api = new Easypost('<YOUR_TEST/PRODUCTION_API_KEY>');

const fromAddress = new api.Address({
  company: 'EasyPost',
  street1: '417 Montgomery Street',
  street2: '5th Floor',
  city: 'San Francisco',
  state: 'CA',
  zip: '94104',
  phone: '415-528-7555',
});

fromAddress.save().then(console.log);
