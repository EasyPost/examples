const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient(process.env.EASYPOST_API_KEY);

(async () => {
  const pickup = await client.Pickup.create({
    address: { id: 'adr_...' },
    shipment: { id: 'shp_...' },
    reference: 'my-first-pickup',
    min_datetime: '2022-10-01 10:30:00',
    max_datetime: '2022-10-02 10:30:00',
    is_account_address: false,
    instructions: 'Special pickup instructions',
  });

  console.log(pickup);
})();
