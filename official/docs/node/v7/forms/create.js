const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const shipmentWithForm = await client.Shipment.generateForm('shp_...', 'return_packing_slip', {
    barcode: 'RMA12345678900',
    line_items: [
      {
        product: {
          title: 'Square Reader',
          barcode: '855658003251',
        },
        units: '8',
      },
    ],
  });

  console.log(shipmentWithForm);
})();
