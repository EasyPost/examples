const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const webhook = await client.Webhook.create({
    url: 'example.com',
    webhook_secret: 'A1B2C3',
  });

  console.log(webhook);
})();
