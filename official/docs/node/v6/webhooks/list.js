const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const webhooks = await client.Webhook.all();

  console.log(webhooks);
})();
