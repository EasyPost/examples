const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient(process.env.EASYPOST_API_KEY);

(async () => {
  const shipment = await client.Shipment.retrieve('shp_...');

  const estimatedDeliveryDates = await client.Shipment.retrieveEstimatedDeliveryDate(
    shipment.id,
    'YYYY-MM-DD',
  );

  console.log(estimatedDeliveryDates);
})();
