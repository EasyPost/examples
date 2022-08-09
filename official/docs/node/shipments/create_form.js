const Easypost = require('@easypost/api');
const api = new Easypost('EASYPOST_API_KEY');

const form = api.Shipment.generateForm('return_packing_slip', {
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

console.log(form);
