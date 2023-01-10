const Easypost = require('@easypost/api');

const api = new Easypost(process.env.EASYPOST_API_KEY);

api.Beta.Referral.refundByAmount(2000).then(console.log);
