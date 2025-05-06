const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const carrierAccount = await client.CarrierAccount.create({
    type: 'DhlEcsAccount',
    description: 'CA Location DHL eCommerce Solutions Account',
    credentials: {
      client_id: '123456',
      client_secret: '123abc',
      distribution_center: 'USLAX1',
      pickup_id: '123456',
    },
    test_credentials: {
      client_id: '123456',
      client_secret: '123abc',
      distribution_center: 'USLAX1',
      pickup_id: '123456',
    },
  });

  console.log(carrierAccount);
})();
