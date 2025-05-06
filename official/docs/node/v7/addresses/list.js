const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const addresses = await client.Address.all({
    page_size: 5,
  });

  console.log(addresses);
})();
