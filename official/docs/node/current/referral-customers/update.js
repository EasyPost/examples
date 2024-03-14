const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  await client.ReferralCustomer.updateEmail('user_...', 'new_email@example.com');
})();
