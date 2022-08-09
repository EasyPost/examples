const Easypost = require('@easypost/api');
const api = new Easypost('EASYPOST_API_KEY');

api.Shipment.retrieve('shp_...').then((s) => {
  s.insure(100).then(() => console.log(s));
});
