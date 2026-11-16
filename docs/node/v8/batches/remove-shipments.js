const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const batch = await client.Batch.removeShipments('batch_...', ['shp_...']);

  console.log(batch);
})();
