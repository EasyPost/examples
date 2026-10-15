const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const shipment = await client.Shipment.retrieve('shp_...');

  const smartRates = shipment.getSmartrates(shipment.id);

  console.log(smartRates);
})();
