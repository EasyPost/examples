const Easypost = require('@easypost/api');

const api = new Easypost(process.env.EASYPOST_API_KEY);

const carrierAccount = api.CarrierAccount.retrieve('ca_...');

carrierAccount.credentials.pickup_id = 'abc123';

carrierAccount.save().then(console.log);
