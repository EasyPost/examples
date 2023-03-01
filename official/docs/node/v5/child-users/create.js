const Easypost = require('@easypost/api');

const api = new Easypost(process.env.EASYPOST_API_KEY);

const user = new api.User({
  name: 'Child Account Name',
});

user.save().then(console.log);
