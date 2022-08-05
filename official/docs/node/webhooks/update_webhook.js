const Easypost = require('@easypost/api');
const api = new Easypost('EASYPOST_API_KEY');

api.Webhook.retrieve(webhookId).then(wh => {
    wh.save().then(console.log);
  });
