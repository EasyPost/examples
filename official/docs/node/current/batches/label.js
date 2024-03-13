const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const batch = await client.Batch.retrieve('batch_...');

  const batchWithLabel = await client.Batch.generateLabel(batch.id, 'PDF');

  console.log(batchWithLabel);
})();
