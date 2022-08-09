const Easypost = require('@easypost/api');
const api = new Easypost('EASYPOST_API_KEY');

const webhookId = api.Webhook.retrieve('hook_...').then(console.log);

api.Webhook.retrieve(webhookId).then((wh) => {
  wh.save().then(console.log);
});
