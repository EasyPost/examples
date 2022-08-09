const Easypost = require('@easypost/api');
const api = new Easypost('EASYPOST_API_KEY');

api.CarrierAccount.retrieve('ca_...').then((ca) => {
  ca.credentials['pickup_id'] = 'abc123';
  ca.save().then(console.log);
});
