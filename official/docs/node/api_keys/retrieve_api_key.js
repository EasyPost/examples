const Easypost = require('@easypost/api');
const api = new Easypost('EASYPOST_API_KEY');

api.ApiKey.all().then(console.log).catch(console.log)

api.User.retrieve('user_...')
  .then(child => console.log(child.api_keys));
