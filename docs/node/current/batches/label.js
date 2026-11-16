const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const batch = await client.Batch.generateLabel('batch_...', 'PDF');

  console.log(batch);
})();
