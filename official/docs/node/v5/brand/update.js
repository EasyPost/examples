const Easypost = require('@easypost/api');

const api = new Easypost(process.env.EASYPOST_API_KEY);

api.User.retrieveMe().then((user) => {
  user.updateBrand({ color: '#303F9F' }).then(console.log);
});
