const Easypost = require('@easypost/api');
const api = new Easypost('EASYPOST_API_KEY');

const user = new api.User({
  name: 'Child Account Name',
});

user.save().then((u) => console.log(u.id));
