const Easypost = require('@easypost/api');

const api = new Easypost(process.env.EASYPOST_API_KEY);

api.CarrierAccount.retrieve('ca_...').then(console.log);
