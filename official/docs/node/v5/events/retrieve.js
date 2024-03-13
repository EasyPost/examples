const Easypost = require('@easypost/api');

const api = new Easypost('EASYPOST_API_KEY');

api.Event.retrieve('evt_...').then(console.log);
