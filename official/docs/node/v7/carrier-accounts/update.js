const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const CarrierAccount = await client.CarrierAccount.update('ca_...', {
    description: 'FL Location DHL eCommerce Solutions Account',
    credentials: { pickup_id: 'abc123' },
  });

  console.log(CarrierAccount);
})();
