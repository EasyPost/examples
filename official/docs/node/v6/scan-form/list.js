const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const scanForms = await client.ScanForm.all({
    page_size: 5,
  });

  console.log(scanForms);
})();
