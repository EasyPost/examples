const Easypost = require('@easypost/api');
const api = new Easypost(process.env.EASYPOST_API_KEY);

api.EndShipper.retrieve('es_...').then(console.log);
