const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient(process.env.EASYPOST_API_KEY);

(async () => {
  const order = await client.Order.create({
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

  console.log(order);
})();
