const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const session = await client.Embeddable.createSession({
    origin_host: 'https://example.com',
    user_id: 'user_...',
  });

  console.log(session);
})();
