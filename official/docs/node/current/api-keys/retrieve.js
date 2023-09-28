const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient(process.env.EASYPOST_API_KEY);

(async () => {
  let apiKeys;

  // Retrieve all API keys including children
  apiKeys = await client.ApiKey.all();

  // Retrieve API keys for a specific child user
  client.User.apiKeys('user_...').then((childApiKeys) => console.log(childApiKeys));

  console.log(apiKeys);
})();
