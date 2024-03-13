const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const pickup = await client.Pickup.retrieve('pickup_...');

  const cancelledPickup = pickup.cancel(pickup.id);

  console.log(cancelledPickup);
})();
