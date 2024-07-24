const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const claim = await client.Claim.cancel('clm_...');

  console.log(claim);
})();
