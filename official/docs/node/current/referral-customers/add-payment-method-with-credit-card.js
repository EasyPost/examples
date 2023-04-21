const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient(process.env.EASYPOST_API_KEY);

(async () => {
  const paymentMethod = await client.BetaReferralCustomer.addPaymentMethod('cus_...', 'card_...');

  console.log(paymentMethod);
})();
