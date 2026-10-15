const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const rates = await client.Shipment.regenerateRates('shp_...');

  console.log(rates);
})();
