const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient(process.env.EASYPOST_API_KEY);

(async () => {
  await client.Referral.updateEmail('user_...', 'new_email@example.com');
})();
