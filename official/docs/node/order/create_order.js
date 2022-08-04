const Easypost = require('@easypost/api');
const api = new Easypost('EASYPOST_API_KEY');

const order = new api.Order({
    to_address: { id: "adr_..." },
    from_address: { id: "adr_..." },
    shipments: [
      new api.Shipment({
        parcel: {
          weight: 10.2
        }
      }),
      new api.Shipment({
        parcel: {
          predefined_package: 'FedExBox',
          weight: 17.5
        }
      })
    ]
});
  
order.save().then(console.log);
