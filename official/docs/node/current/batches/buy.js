const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const createdBatch = await client.Batch.create({
    shipments: [
      {
        from_address: { id: 'adr_...' },
        to_address: { id: 'adr_...' },
        parcel: { id: 'prcl_...' },
        service: 'First',
        carrier: 'USPS',
        carrier_accounts: ['ca_...'],
      },
    ],
  });

  const batch = await client.Batch.buy(createdBatch.id);

  console.log(batch);
})();
