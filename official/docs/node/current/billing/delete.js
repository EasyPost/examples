const Easypost = require('@easypost/api');

const api = new Easypost(process.env.EASYPOST_API_KEY);

api.Billing.deletePaymentMethod('primary').then(console.log);