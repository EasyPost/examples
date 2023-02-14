const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient(process.env.EASYPOST_API_KEY);

(async () => {
  const carrierAccount = await client.CarrierAccount.retrieve('ca_...');

  const updatedCarrierAccount = await client.CarrierAccount.update(carrierAccount.id, {
    credentials: { pickup_id: 'abc123' },
  });

  console.log(updatedCarrierAccount);
})();
