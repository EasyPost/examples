const Easypost = require('@easypost/api');
const api = new Easypost('EASYPOST_API_KEY');

api.Shipment.retrieve('shp_...').then(s => {
    s.buy('rate_...', 249.99).then(console.log);
  });
