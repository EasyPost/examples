const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const response = await client.BetaReferralCustomer.createBankAccountClientSecret();

  console.log(response);
})();
