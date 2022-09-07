const Easypost = require('@easypost/api');

const api = new Easypost(process.env.EASYPOST_API_KEY);

api.Pickup.retrieve('pickup_...').then((retrievedPickup) => {
  retrievedPickup.cancel().then(console.log);
});
