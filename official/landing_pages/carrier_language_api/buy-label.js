const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient(process.env.EASYPOST_API_KEY);

(async () => {
  const shipment = await client.Shipment.create({
    to_address,
    from_address,
    parcel: {
      predefined_package: 'Parcel',
      weight: 28,
    },
  });

  await client.Shipment.buy(shipment.id, shipment.lowestRate());
})();
