const EasyPost = require('@easypost/api');

const api = new EasyPost('EASYPOST_API_KEY');

(async () => {
  const shipment = await api.Shipment.retrieve('shp_...');
  await shipment.buy(shipment.lowestRate());
  console.log(shipment);
})();
