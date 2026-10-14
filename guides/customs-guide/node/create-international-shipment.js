const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const shipment = await client.Shipment.create({
    to_address: {
      name: 'Tim Canterbury',
      company: 'Wernham Hogg',
      street1: '118 Clippenham Lane',
      city: 'Slough',
      country: 'GB',
      zip: 'SL15BE',
    },
    from_address: {
      company: 'EasyPost',
      street1: '417 Montgomery Street',
      street2: '5th Floor',
      city: 'San Francisco',
      state: 'CA',
      zip: '94104',
      phone: '415-528-7555',
    },
    parcel: {
      length: 9,
      width: 6,
      height: 3,
      weight: 20,
    },
    customs_info: {
      eel_pfc: 'NOEEI 30.37(a)',
      customs_certify: true,
      customs_signer: 'Steve Brule',
      contents_type: 'merchandise',
      contents_explanation: '',
      restriction_type: 'none',
      restriction_comments: '',
      customs_items: [
        {
          description: 'T-shirts',
          quantity: 1,
          weight: 5,
          value: 10,
          hs_tariff_number: '123456',
          origin_country: 'US',
        },
      ],
    },
  });

  console.log(shipment);
})();
