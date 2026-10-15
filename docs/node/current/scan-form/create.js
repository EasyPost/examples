const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const scanForm = await client.ScanForm.create({
    shipments: [{ id: 'shp_...' }, { id: 'shp_...' }],
  });

  console.log(scanForm);
})();
