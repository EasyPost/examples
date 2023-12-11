const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient(process.env.EASYPOST_API_KEY);

(async () => {
  // Retrieve all API keys including children
  let apiKeys = await client.ApiKey.all();

  console.log(apiKeys);

  // Retrieve API keys for a specific child user
  let childApiKeys = await client.ApiKey.retrieveApiKeysForUser('user_...');

  console.log(childApiKeys);
})();
