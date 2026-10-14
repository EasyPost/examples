const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const shipment = await client.Shipment.retrieve('shp_...');

  const shipmentWithLabel = await client.Shipment.convertLabelFormat(shipment.id, 'ZPL');

  console.log(shipmentWithLabel);
})();
