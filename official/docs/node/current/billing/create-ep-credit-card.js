const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient(process.env.EASYPOST_API_KEY);
const referralUserApiKey = process.env.REFERRAL_USER_API_KEY;

(async () => {
  const creditCard = await client.Referral.addCreditCard(
    referralUserApiKey,
    '0123456789101234',
    '01',
    '2025',
    '111',
  );

  console.log(creditCard);
})();
