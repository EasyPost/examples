const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const carrierAccount = await client.CarrierAccount.retrieve('ca_...');

  const updatedCarrierAccount = await client.CarrierAccount.update(carrierAccount.id, {
    description: 'FL Location DHL eCommerce Solutions Account',
    credentials: { pickup_id: 'abc123' },
  });

  console.log(updatedCarrierAccount);
})();
