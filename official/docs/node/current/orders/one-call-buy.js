const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const order = await client.Order.create({
    carrier_accounts: ['ca_...'],
    service: 'NextDayAir',
    to_address: 'adr_...',
    from_address: 'adr_...',
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
