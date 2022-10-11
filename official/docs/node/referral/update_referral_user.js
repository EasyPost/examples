const Easypost = require('@easypost/api');
const api = new Easypost('<YOUR_PRODUCTION_API_KEY>');

api.Referral.updateEmail('user_...', 'new_email@example.com').then(console.log);
