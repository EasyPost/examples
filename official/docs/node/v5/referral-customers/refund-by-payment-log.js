const Easypost = require('@easypost/api');

const api = new Easypost('EASYPOST_API_KEY');

api.Beta.Referral.refundByPaymentLog('paylog_...').then(console.log);
