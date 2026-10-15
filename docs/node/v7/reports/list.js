const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  // Replace `payment_log` with any of the report types listed above
  const reports = await client.Report.all('payment_log', { page_size: 5 });

  console.log(reports);
})();
