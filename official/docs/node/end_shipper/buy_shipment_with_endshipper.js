const Easypost = require('@easypost/api');

const api = new Easypost(process.env.EASYPOST_API_KEY);

api.Shipment.retrieve('shp_...').then((retrievedShipment) => {
  retrievedShipment.buy('rate_...', null, false, 'es_...').then(console.log);
});
