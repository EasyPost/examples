const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const paymentMethod = await client.ReferralCustomer.addBankAccountFromStripe(
    'REFERRAL_USER_API_KEY',
    'fca_...',
    {
      ip_address: '127.0.0.1',
      user_agent: 'Mozilla/5.0',
      accepted_at: 172251073,
    },
    'primary',
  );

  console.log(paymentMethod);
})();
