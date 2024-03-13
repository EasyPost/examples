const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const pickups = await client.Pickup.all({
    page_size: 5,
  });

  console.log(pickups);
})();
