const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const cancelledPickup = await client.Pickup.cancel('pickup_...');

  console.log(cancelledPickup);
})();
