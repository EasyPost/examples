const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const address = await client.Address.verifyAddress('adr_...');

  console.log(address);
})();
