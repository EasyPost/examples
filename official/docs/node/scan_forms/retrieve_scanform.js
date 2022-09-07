const Easypost = require('@easypost/api');

const api = new Easypost(process.env.EASYPOST_API_KEY);

api.ScanForm.retrieve('sf_...').then(console.log);
