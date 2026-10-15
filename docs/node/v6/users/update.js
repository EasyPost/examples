const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const user = await client.User.retrieveMe();

  const updatedUser = await client.User.update(user.id, { recharge_threshold: '50.00' });

  console.log(updatedUser);
})();
