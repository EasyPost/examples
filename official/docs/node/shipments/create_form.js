const Easypost = require('@easypost/api');

const api = new Easypost(process.env.EASYPOST_API_KEY);

api.Shipment.retrieve('shp_...').then((shipment) => {
  shipment
    .generateForm('return_packing_slip', {
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
    })
    .then(console.log);
});
