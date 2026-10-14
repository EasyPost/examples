const Easypost = require('@easypost/api');

const api = new Easypost('EASYPOST_API_KEY');

api.Beta.Referral.addPaymentMethod('cus_...', 'ba_...').then(console.log);
