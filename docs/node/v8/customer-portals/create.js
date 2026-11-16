const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const accountLink = await client.CustomerPortal.createAccountLink({
    session_type: 'account_management',
    user_id: 'user_...',
    refresh_url: 'https://example.com/refresh',
    return_url: 'https://example.com/return',
    metadata: { target: 'wallet' },
  });

  console.log(accountLink);
})();
