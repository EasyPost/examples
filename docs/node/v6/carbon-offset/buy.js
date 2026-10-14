const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const shipment = await client.Shipment.retrieve('shp_...');

  const boughtShipment = await client.Shipment.buy(
    shipment.id,
    shipment.lowestRate(),
    249.99,
    true,
  );

  console.log(boughtShipment);
})();
