const Easypost = require('@easypost/api');
const api = new Easypost('EASYPOST_API_KEY');

const order = new api.Order({
    carrier_accounts: ['ca_...'],
    service: 'NextDayAir',	
    to_address: 'adr_...',
    from_address: 'adr_...',
    shipments: [
      new api.Shipment({
        parcel: {
          predefined_package: 'FedExBox',
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
