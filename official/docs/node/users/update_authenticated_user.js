const Easypost = require('@easypost/api');

const api = new Easypost(process.env.EASYPOST_API_KEY);

api.User.retrieveMe().then((user) => {
  user.recharge_threshold = '50.00';
  user.save().then(console.log);
});
