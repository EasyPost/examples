const Easypost = require('@easypost/api');
const api = new Easypost('<YOUR_PRODUCTION_API_KEY>');

// If no user id is passed in, the user returned is the owner of the api key.
api.User.retrieve(userId).then(u =>
  u.recharge_threshold = '50.00';
  u.save().catch(console.error);
);
