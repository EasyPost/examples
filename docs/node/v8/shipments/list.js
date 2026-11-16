const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const shipments = await client.Shipment.all({
    page_size: 5,
  });

  console.log(shipments);
})();
