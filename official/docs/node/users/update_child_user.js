const Easypost = require('@easypost/api');

const api = new Easypost(process.env.EASYPOST_API_KEY);

api.User.retrieve('rate_...').then((user) => {
  user.name = 'Test Child';
  user.save().then(console.log);
});
