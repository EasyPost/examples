const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const shipment = await client.Shipment.retrieve('shp_...');

  const shipmentWithForm = shipment.generateForm(shipment.id, 'return_packing_slip', {
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
