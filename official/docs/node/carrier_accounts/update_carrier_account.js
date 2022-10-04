const Easypost = require('@easypost/api');

const api = new Easypost(process.env.EASYPOST_API_KEY);

api.CarrierAccount.retrieve('ca_...').then((carrierAccount) => {
  carrierAccount.credentials.pickup_id = 'abc123';
  carrierAccount.save().then(console.log);
});
