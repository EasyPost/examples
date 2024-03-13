const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const retrievedAddress = await client.Address.retrieve('adr_...');

  console.log(retrievedAddress);
})();