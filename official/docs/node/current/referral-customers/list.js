const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient(process.env.EASYPOST_API_KEY);

(async () => {
  const referralCustomers = await client.ReferralCustomer.all({
    page_size: 5,
  });

  console.log(referralCustomers);
})();
