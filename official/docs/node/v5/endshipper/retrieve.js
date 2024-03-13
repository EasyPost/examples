const Easypost = require('@easypost/api');
const api = new Easypost('EASYPOST_API_KEY');

api.EndShipper.retrieve('es_...').then(console.log);
