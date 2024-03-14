const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const batch = await client.Batch.retrieve('batch_...');

  const batchWithShipments = await client.Batch.addShipments(batch.id, ['shp_...', 'shp_...']);

  console.log(batchWithShipments);
})();
