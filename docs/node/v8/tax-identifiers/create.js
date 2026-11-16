const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const shipment = await client.Shipment.create({
    parcel: {
      length: 20.2,
      width: 10.9,
      height: 5,
      weight: 65.9,
    },
    to_address: {
      name: 'Dr. Steve Brule',
      street1: '179 N Harbor Dr',
      city: 'Redondo Beach',
      state: 'CA',
      zip: '90277',
      country: 'US',
      email: 'dr_steve_brule@gmail.com',
      phone: '4155559999',
    },
    from_address: {
      street1: '417 montgomery street',
      street2: 'FL 5',
      city: 'San Francisco',
      state: 'CA',
      zip: '94104',
      country: 'US',
      company: 'EasyPost',
      phone: '415-123-4567',
    },
    customs_info: {
      id: 'cstinfo_...',
    },
    tax_identifiers: [
      {
        entity: 'SENDER',
        tax_id: 'GB123456789',
        tax_id_type: 'IOSS',
        issuing_country: 'GB',
      },
    ],
  });

  console.log(shipment);
})();
