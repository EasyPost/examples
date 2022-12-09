const Easypost = require('@easypost/api');

const api = new Easypost(process.env.EASYPOST_API_KEY);

const referralUserApiKey = process.env.REFERRAL_USER_API_KEY;

await api.Referral.addCreditCard(referralUserApiKey, '0123456789101234', '01', '2025', '111').then(
  console.log,
);
