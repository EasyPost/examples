const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const claim = await client.Claim.refund('clm_...');

  console.log(claim);
})();
