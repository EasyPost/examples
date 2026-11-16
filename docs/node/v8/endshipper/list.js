const EasyPostClient = require('@easypost/api');
const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const endShippers = await client.EndShipper.all({
    page_size: 5,
  });

  console.log(endShippers);
})();
