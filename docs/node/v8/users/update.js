const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const user = await client.User.update('user_...', { recharge_threshold: '50.00' });

  console.log(user);
})();
