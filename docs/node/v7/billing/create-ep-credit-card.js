const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const creditCard = await client.Referral.addCreditCard(
    'REFERRAL_USER_API_KEY',
    '0123456789101234',
    '01',
    '2025',
    '111',
  );

  console.log(creditCard);
})();
