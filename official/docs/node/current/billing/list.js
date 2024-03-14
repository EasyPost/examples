const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const paymentMethods = await client.Billing.all();

  console.log(paymentMethods);
})();
