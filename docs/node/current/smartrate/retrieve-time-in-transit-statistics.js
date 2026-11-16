const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const smartRates = await client.Shipment.getSmartRates('shp_...');

  console.log(smartRates);
})();
