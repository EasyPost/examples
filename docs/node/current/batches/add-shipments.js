const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const batch = await client.Batch.addShipments('batch_...', ['shp_...', 'shp_...']);

  console.log(batch);
})();
