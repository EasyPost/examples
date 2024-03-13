const Easypost = require('@easypost/api');

const api = new Easypost('EASYPOST_API_KEY');

const webhook = new api.Webhook({ url: 'example.com' });

webhook.save().then(console.log);
