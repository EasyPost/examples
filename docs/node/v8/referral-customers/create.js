const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const referralCustomer = await client.ReferralCustomer.create({
    name: 'Test Referral',
    email: 'test@example.com',
    phone: '1111111111',
  });

  console.log(referralCustomer);
})();
