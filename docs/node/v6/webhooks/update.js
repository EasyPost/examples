const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const webhook = await client.Webhook.retrieve('hook_...');

  const updatedWebhook = await client.Webhook.update(webhook.id);

  console.log(updatedWebhook);
})();
