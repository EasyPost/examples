const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const carrierTypes = await client.CarrierType.all();

  console.log(carrierTypes);
})();
