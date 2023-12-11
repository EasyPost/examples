const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient(process.env.EASYPOST_API_KEY);

(async () => {
  const shipment = await client.Shipment.retrieve('shp_...');

  const rates = await client.Shipment.regenerateRates(shipment.id);

  console.log(rates);
})();
