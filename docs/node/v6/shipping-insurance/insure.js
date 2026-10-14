const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const shipment = await client.Shipment.retrieve('shp_...');

  const insuredShipment = await client.Shipment.insure(shipment.id, 100);

  console.log(insuredShipment);
})();
