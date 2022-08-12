const Easypost = require('@easypost/api');
const api = new Easypost('EASYPOST_API_KEY');

api.Rate.retrieve('rate...').then((retrieveRate) => {
  retrieveRate.cancel().then(console.log);
});
