const Easypost = require('@easypost/api');
const api = new Easypost('EASYPOST_API_KEY');

api.CustomsInfo.retrieve('cstinfo_...').then(console.log);
