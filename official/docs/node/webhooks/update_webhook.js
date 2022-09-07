const Easypost = require('@easypost/api');

const api = new Easypost(process.env.EASYPOST_API_KEY);

const webhookId = api.Webhook.retrieve('hook_...').then(console.log);

api.Webhook.retrieve(webhookId).then((retrievedWebhook) => {
  retrievedWebhook.save().then(console.log);
});
