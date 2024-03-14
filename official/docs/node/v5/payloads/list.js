const Easypost = require('@easypost/api');

const api = new Easypost('EASYPOST_API_KEY');

api.Event.retrieveAllPayloads('evt_...').then(console.log);
