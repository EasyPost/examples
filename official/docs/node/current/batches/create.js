const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const batch = await client.Batch.create({
    shipments: [{ id: 'shp_...' }, { id: 'shp_...' }],
  });

  console.log(batch);
})();
