const Easypost = require('@easypost/api');

const api = new Easypost(process.env.EASYPOST_API_KEY);

api.Pickup.retrieve('pickup_...').then((retrievedPickup) => {
  retrievedPickup.buy('UPS', 'Same-day Pickup').then(console.log);
});
