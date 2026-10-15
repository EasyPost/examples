const Easypost = require('@easypost/api');

const api = new Easypost('EASYPOST_API_KEY');

api.CarrierType.all().then(console.log);
