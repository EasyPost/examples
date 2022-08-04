const Easypost = require('@easypost/api');
const api = new Easypost('EASYPOST_API_KEY');

const carrier_account = new api.CarrierAccount({ id: '<ca_...>' });

carrier_account.delete();

console.log(carrier_account);
