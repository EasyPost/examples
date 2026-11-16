const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const apiKey = await client.ApiKey.enable('ak_...');

  console.log(apiKey);
})();
