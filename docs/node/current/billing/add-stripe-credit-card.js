const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const paymentMethod = await client.ReferralCustomer.addCreditCardFromStripe(
    'REFERRAL_USER_API_KEY',
    'seti_...',
    'primary',
  );

  console.log(paymentMethod);
})();
