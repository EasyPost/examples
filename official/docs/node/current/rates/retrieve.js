const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient(process.env.EASYPOST_API_KEY);

(async () => {
  const rate = await client.Rate.retrieve('rate...');

  console.log(rate);
})();
