const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient(process.env.EASYPOST_API_KEY);

(async () => {
  let apiKeys;

  // Retrieve all API keys including children
  apiKeys = await client.ApiKey.all();

  // Retrieve API keys for a specific child user
  apiKeys = await client.User.retrieve('user_...');

  console.log(apiKeys);
})();
