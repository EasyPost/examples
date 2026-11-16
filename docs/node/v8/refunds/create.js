const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const refund = await client.Refund.create({
    carrier: 'USPS',
    tracking_codes: ['EZ1000000001'],
  });

  console.log(refund);
})();
