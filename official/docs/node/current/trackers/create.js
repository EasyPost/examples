const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient(process.env.EASYPOST_API_KEY);

(async () => {
  const tracker = await client.Tracker.create({
    tracking_code: 'EZ1000000001',
    carrier: 'USPS',
  });

  console.log(tracker);
})();
