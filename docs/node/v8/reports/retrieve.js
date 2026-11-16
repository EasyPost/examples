const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const report = await client.Report.retrieve('<REPORT_ID>');

  console.log(report);
})();
