const Easypost = require('@easypost/api');

const api = new Easypost(process.env.EASYPOST_API_KEY);

api.Pickup.retrieve('pickup_...').then((pickup) => {
  pickup.cancel().then(console.log);
});
