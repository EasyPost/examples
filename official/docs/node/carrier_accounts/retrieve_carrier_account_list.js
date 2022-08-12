const Easypost = require('@easypost/api');
const api = new Easypost('EASYPOST_API_KEY');

api.CarrierAccount.all().then(console.log);
