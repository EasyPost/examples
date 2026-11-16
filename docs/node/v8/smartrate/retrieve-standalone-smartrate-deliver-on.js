const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const results = await client.SmartRate.recommendShipDate({
    from_zip: '10001',
    to_zip: '10002',
    desired_delivery_date: '2024-07-18',
    carriers: ['UPS'],
  });

  console.log(results);
})();
