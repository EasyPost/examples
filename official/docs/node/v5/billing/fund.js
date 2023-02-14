const Easypost = require('@easypost/api');

const api = new Easypost(process.env.EASYPOST_API_KEY);

api.Billing.fund('2000', 'primary').then(console.log);
