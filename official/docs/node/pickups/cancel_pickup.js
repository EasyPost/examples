const Easypost = require('@easypost/api');
const api = new Easypost('EASYPOST_API_KEY');

api.Pickup.retrieve('pickup_...').then((retrievePickup) => {
  retrievePickup.cancel().then(console.log);
});