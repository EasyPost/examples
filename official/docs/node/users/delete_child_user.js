const Easypost = require('@easypost/api');
const api = new Easypost('EASYPOST_API_KEY');

api.User.delete('user_...').then(console.log);
