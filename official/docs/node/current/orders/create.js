const Easypost = require('@easypost/api');

const api = new Easypost(process.env.EASYPOST_API_KEY);

const order = new api.Order({
  to_address: { id: 'adr_...' },
  from_address: { id: 'adr_...' },
  shipments: [
    {
      parcel: {
        weight: 10.2,
      },
    },
    {
      parcel: {
        predefined_package: 'FedExBox',
        weight: 17.5,
      },
    },
  ],
});

order.save().then(console.log);
