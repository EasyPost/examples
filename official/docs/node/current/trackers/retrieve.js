const Easypost = require('@easypost/api');

const api = new Easypost(process.env.EASYPOST_API_KEY);

api.Tracker.retrieve('trk_...').then(console.log);
