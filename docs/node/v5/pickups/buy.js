const Easypost = require('@easypost/api');

const api = new Easypost('EASYPOST_API_KEY');

api.Pickup.retrieve('pickup_...').then((pickup) => {
  pickup.buy('UPS', 'Same-day Pickup').then(console.log);
});
