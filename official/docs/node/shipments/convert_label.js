const Easypost = require('@easypost/api');
const api = new Easypost('EASYPOST_API_KEY');

api.Shipment.retrieve('shp_...').then((shipment) => {
  shipment.convertLabelFormat('ZPL').then(console.log);
});
