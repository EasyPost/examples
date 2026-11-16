const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const customsItem = await client.CustomsItem.create({
    description: 'T-shirt',
    quantity: 1,
    value: 10,
    weight: 5,
    hs_tariff_number: '123456',
    origin_country: 'us',
  });

  console.log(customsItem);
})();
