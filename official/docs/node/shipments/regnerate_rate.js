const Easypost = require('@easypost/api');
const api = new Easypost('EASYPOST_API_KEY');

const shipment = api.Shipment.retrieve('shp_...').then((s) => {
  s.regenerateRates().then((sh) =>
    console.dir(sh.rates, {
      depth: null,
    }),
  );
});

console.log(shipment);
