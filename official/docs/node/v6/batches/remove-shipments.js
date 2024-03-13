const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const batch = await client.Batch.retrieve('batch_...');

  const batchWithoutShipments = await client.Batch.removeShipments(batch.id, ['shp_...']);

  console.log(batchWithoutShipments);
})();
