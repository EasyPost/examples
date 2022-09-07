const Easypost = require('@easypost/api');

const api = new Easypost(process.env.EASYPOST_API_KEY);

api.CustomsInfo.retrieve('cstinfo_...').then(console.log);
