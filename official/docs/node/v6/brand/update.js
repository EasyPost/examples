const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient(process.env.EASYPOST_API_KEY);

(async () => {
  const user = await client.User.retrieveMe();

  const brand = await client.User.updateBrand(user.id, { color: '#303F9F' });

  console.log(brand);
})();
