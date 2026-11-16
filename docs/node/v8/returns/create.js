const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const shipment = await client.Shipment.create({
    parcel: { id: 'prcl_...' },
    to_address: { id: 'adr_...' },
    from_address: { id: 'adr_...' },
    is_return: true,
  });

  console.log(shipment);
})();
