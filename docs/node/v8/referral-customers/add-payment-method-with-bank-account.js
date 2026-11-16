const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const paymentMethod = await client.BetaReferralCustomer.addPaymentMethod('cus_...', 'ba_...');

  console.log(paymentMethod);
})();
