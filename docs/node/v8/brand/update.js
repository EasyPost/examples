const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const brand = await client.User.updateBrand('user_...', { color: '#303F9F' });

  console.log(brand);
})();
