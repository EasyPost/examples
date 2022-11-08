const Easypost = require('@easypost/api');
const api = new Easypost('<YOUR_TEST/PRODUCTION_API_KEY>');

const webhook = new api.Webhook({
  url: 'https://example.com',
  webhook_secret: 'A1B2C3'
});

webhook.save().then(console.log);
