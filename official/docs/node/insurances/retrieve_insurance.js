const Easypost = require('@easypost/api');

const api = new Easypost(process.env.EASYPOST_API_KEY);

api.Insurance.retrieve('ins_...').then(console.log);
