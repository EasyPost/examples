const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  client.Billing.fundWallet('2000', 'primary');
})();
