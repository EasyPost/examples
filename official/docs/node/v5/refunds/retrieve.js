const Easypost = require('@easypost/api');

const api = new Easypost('EASYPOST_API_KEY');

api.Refund.retrieve('rfnd_...').then(console.log);
