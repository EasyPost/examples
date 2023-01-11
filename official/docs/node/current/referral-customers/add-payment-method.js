const Easypost = require('@easypost/api');

const api = new Easypost(process.env.EASYPOST_API_KEY);

api.Beta.Referral.addPaymentMethod('cus_123', 'ba_123').then(console.log);
