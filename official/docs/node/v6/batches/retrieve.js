const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient(process.env.EASYPOST_API_KEY);

(async () => {
  const batch = await client.Batch.retrieve('batch_...');

  console.log(batch);
})();
