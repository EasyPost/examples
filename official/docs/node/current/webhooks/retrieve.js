const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient(process.env.EASYPOST_API_KEY);

(async () => {
  const webhook = await client.Webhook.retrieve('hook_...');

  console.log(webhook);
})();
