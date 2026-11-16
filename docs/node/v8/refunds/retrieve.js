const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const refund = await client.Refund.retrieve('rfnd_...');

  console.log(refund);
})();
