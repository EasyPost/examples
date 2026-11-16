const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const webhook = await client.Webhook.retrieve('hook_...');

  console.log(webhook);
})();
