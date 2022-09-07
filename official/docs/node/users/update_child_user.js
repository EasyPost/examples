const Easypost = require('@easypost/api');

const api = new Easypost(process.env.EASYPOST_API_KEY);

const user = api.User.retrieve('rate_...');

user.name = 'Test Child';

user.save().then(console.log);
