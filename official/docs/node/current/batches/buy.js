const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const batch = await client.Batch.retrieve('batch_...');

  const boughtBatch = await client.Batch.buy(batch.id);

  console.log(boughtBatch);
})();
