const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient(process.env.EASYPOST_API_KEY);

(async () => {
  const refund = await client.Beta.ReferralCustomer.refundByAmount(2000);

  console.log(refund);
})();
