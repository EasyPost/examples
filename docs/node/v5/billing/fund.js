const Easypost = require('@easypost/api');

const api = new Easypost('EASYPOST_API_KEY');

api.Billing.fundWallet('2000', 'primary').then(console.log);
