const EasyPost = require('@easypost/api');

const client = new EasyPost('EASYPOST_API_KEY');

(async () => {
  const params = {
    ruleset_name: 'required_deliver_by_date',
    planned_ship_date: '2025-07-18',
    deliver_by_date: '2025-07-20',
  };

  const shipment = await client.Luma.buyLuma('shp_...', params);

  console.log(shipment);
})();
