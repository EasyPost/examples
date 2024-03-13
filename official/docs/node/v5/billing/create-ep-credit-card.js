const Easypost = require('@easypost/api');

const api = new Easypost('EASYPOST_API_KEY');

await api.Referral.addCreditCard(
  'REFERRAL_USER_API_KEY',
  '0123456789101234',
  '01',
  '2025',
  '111',
).then(console.log);
