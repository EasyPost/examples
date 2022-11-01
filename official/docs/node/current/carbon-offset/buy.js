const Easypost = require('@easypost/api');

const api = new Easypost(process.env.EASYPOST_API_KEY);

api.Shipment.retrieve('shp_...').then((s) => {
  s.buy(s.lowestRate(), 249.99, true).then(console.log);
});
