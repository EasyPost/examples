const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const batch = await client.Batch.retrieve('batch_...');

  const batchWithScanForm = await client.Batch.createScanForm(batch.id);

  console.log(batchWithScanForm);
})();
