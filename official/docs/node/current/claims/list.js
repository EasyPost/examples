const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const claims = await client.Claim.all({
    page_size: 5,
  });

  console.log(claims);
})();
