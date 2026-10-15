const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const shipment = await client.Shipment.convertLabelFormat('shp_...', 'ZPL');

  console.log(shipment);
})();
