const Easypost = require('@easypost/api');

const api = new Easypost(process.env.EASYPOST_API_KEY);

api.Address.retrieve('adr_...').then(console.log);
