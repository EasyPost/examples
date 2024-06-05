const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  let user;
  user = client.User.retrieveMe();
  user = client.User.update(user.id, { recharge_threshold: '50.00' });
  console.log(user);
})();
