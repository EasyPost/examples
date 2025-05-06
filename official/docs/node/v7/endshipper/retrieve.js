const EasyPostClient = require('@easypost/api');
const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const endShipper = await client.EndShipper.retrieve('es_...');

  console.log(endShipper);
})();
