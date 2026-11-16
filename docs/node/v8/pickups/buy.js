const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const pickup = await client.Pickup.buy('pickup_...', 'UPS', 'Same-day Pickup');

  console.log(pickup);
})();
