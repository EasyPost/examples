const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const shipment = await client.Shipment.retrieve('shp_...');

  const refundedShipment = await client.Shipment.refund(shipment.id);

  console.log(refundedShipment);
})();
