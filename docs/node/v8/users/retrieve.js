const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  let user;

  // Retrieve the authenticated user
  user = await client.User.retrieveMe();

  // Retrieve a child user
  user = await client.User.retrieve('user_...');

  console.log(user);
})();
