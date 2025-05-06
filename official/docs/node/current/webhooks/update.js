const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const webhook = await client.Webhook.update('hook_...', {
    webhook_secret: 'A1B2C3',
    customer_headers: {
      'X-Header-Name': 'header_value',
    },
  });

  console.log(webhook);
})();
