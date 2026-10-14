const Easypost = require('@easypost/api');

const api = new Easypost('EASYPOST_API_KEY');

api.Rate.retrieve('rate...').then((rate) => {
  rate.cancel().then(console.log);
});
