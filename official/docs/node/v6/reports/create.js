const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient(process.env.EASYPOST_API_KEY);

(async () => {
  const report = await client.Report.create({
    type: 'payment_log',
    start_date: '2022-10-01',
    end_date: '2022-10-31',
  });

  console.log(report);
})();
