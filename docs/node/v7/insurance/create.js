const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const insurance = await client.Insurance.create({
    to_address: { id: 'adr_...' },
    from_address: { id: 'adr_...' },
    tracking_code: '9400110898825022579493',
    carrier: 'USPS',
    amount: '100.00',
    reference: 'insuranceRef1',
  });

  console.log(insurance);
})();
