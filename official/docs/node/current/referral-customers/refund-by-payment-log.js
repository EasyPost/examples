const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient(process.env.EASYPOST_API_KEY);

(async () => {
  const refund = await client.BetaReferralCustomer.refundByPaymentLog('paylog_...');

  console.log(refund);
})();
