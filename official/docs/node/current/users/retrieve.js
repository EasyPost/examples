const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient(process.env.EASYPOST_API_KEY);

(async () => {
  let user;

  // Retrieve the authenticated user
  user = await client.User.retrieveMe().then(console.log);

  // Retrieve a child user
  user = await client.User.retrieve('user_...').then(console.log);

  console.log(user);
})();
