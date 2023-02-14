const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient(process.env.EASYPOST_API_KEY);

(async () => {
  const webhook = await client.Webhook.create({ url: 'example.com' });

  console.log(webhook);
})();
