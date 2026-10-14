const Easypost = require('@easypost/api');

const api = new Easypost('EASYPOST_API_KEY');

api.CarrierAccount.retrieve('ca_...').then((carrierAccount) =>
  carrierAccount.delete().then(console.log),
);
