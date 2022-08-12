const Easypost = require('@easypost/api');
const api = new Easypost('EASYPOST_API_KEY');

api.Webhook.all().then(console.log);
