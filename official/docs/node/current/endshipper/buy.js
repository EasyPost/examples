const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient(process.env.EASYPOST_API_KEY);

(async () => {
  const shipment = await client.Shipment.retrieve('shp_...');

  const shipmentWithEndShipperId = await client.Shipment.buy(
    shipment.id,
    shipment.lowestRate(),
    null,
    false,
    'es_...',
  );

  console.log(shipmentWithEndShipperId);
})();
