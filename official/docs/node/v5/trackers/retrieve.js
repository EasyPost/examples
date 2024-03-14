const Easypost = require('@easypost/api');

const api = new Easypost('EASYPOST_API_KEY');

api.Tracker.retrieve('trk_...').then(console.log);
