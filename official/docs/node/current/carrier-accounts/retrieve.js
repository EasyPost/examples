const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const carrierAccount = await client.CarrierAccount.retrieve('ca_...');

  console.log(carrierAccount);
})();
