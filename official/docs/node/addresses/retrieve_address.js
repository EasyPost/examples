const Easypost = require('@easypost/api');
const api = new Easypost('EASYPOST_API_KEY');

api.Address.retrieve('adr_...').then(console.log);
