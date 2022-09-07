const Easypost = require('@easypost/api');

const api = new Easypost(process.env.EASYPOST_API_KEY);

const user = api.User.retrieveMe();

user.recharge_threshold = '50.00';

user.save();

console.log(user);
