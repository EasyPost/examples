const Easypost = require('@easypost/api');
const api = new Easypost('EASYPOST_API_KEY');

const carrierAccount = new api.CarrierAccount({ id: '<ca_...>' });

carrierAccount.delete().then(console.log);
