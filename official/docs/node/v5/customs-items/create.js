const Easypost = require('@easypost/api');

const api = new Easypost('EASYPOST_API_KEY');

const customsItem = new api.CustomsItem({
  description: 'T-shirt',
  quantity: 1,
  value: 10,
  weight: 5,
  hs_tariff_number: '123456',
  origin_country: 'us',
});

customsItem.save().then(console.log);
