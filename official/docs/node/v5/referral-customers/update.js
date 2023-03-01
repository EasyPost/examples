const Easypost = require('@easypost/api');

const api = new Easypost(process.env.EASYPOST_API_KEY);

api.Referral.updateEmail('user_...', 'new_email@example.com');
