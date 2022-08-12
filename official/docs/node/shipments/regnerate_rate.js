const Easypost = require('@easypost/api');
const api = new Easypost('EASYPOST_API_KEY');

const shipment = api.Shipment.retrieve('shp_...').then((retrieveShipment) => {
  retrieveShipment.regenerateRates().then((shipmentRate) =>
    console.dir(shipmentRate.rates, {
      depth: null,
    }),
  );
});

shipment.save().then(console.log);
