const Easypost = require('@easypost/api');

const api = new Easypost(process.env.EASYPOST_API_KEY);

api.Beta.Referral.addPaymentMethod('cus_...', 'card_...').then(console.log);
