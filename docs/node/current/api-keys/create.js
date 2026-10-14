const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const apiKey = await client.ApiKey.create('test');

  console.log(apiKey);
})();
