const Easypost = require('@easypost/api');

const api = new Easypost('EASYPOST_API_KEY');

api.Webhook.retrieve('hook_...').then(console.log);
